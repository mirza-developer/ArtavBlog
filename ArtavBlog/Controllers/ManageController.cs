using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtavBlog.Models.Account;
using ArtavBlog.Models.Base;
using ArtavBlog.Models.Messaging.CustomerCare;
using ArtavBlog.Models.Messaging.Public;
using ArtavBlog.Repository.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ArtavBlog.Controllers
{
    [Authorize(Roles = "User")]
    public class ManageController : Controller
    {
        //     private BlogContext _context;
        private ISqlBaseRepository<CareMessage> _repos;
        private UserManager<ApplicationUser> _userManager;
        public ManageController(ISqlBaseRepository<CareMessage> repos, UserManager<ApplicationUser> userManager)
        {
            _repos = repos;
            _userManager = userManager;
        }
        public IActionResult CareChat()
        {
            var calendar = new AvizheCalendar.BLL.WorkingWithPersianCalendar();
            var availCareChats = _repos.GetDataByQuery
                (" SELECT * FROM SignalR.CareMessage WHERE CareMessage.ID IN(SELECT Nested.ID " +
                " FROM(select ID,RANK() OVER(PARTITION BY CareMessage.ConnectionId ORDER BY CareMessage.CreateDateAndTime DESC) " +
                " [Ranking] from SignalR.CareMessage) as Nested WHERE Nested.Ranking =1)  AND IsDeleted = 0 ")
                .Select(p => new Chat()
                {
                    ConnectionId = p.ConnectionId,
                    LastMessageText = p.MessageText.Length > 20 ? (p.MessageText.Substring(0, 20) + " ..") : p.MessageText,
                    LastMessagePersianDate = calendar.GregorianToPersian(p.CreateDateAndTime),
                    LastMessageTime = p.CreateDateAndTime.ToShortTimeString(),
                    SenderName = (p.CreatorIdentityID == string.Empty ? "Operator": p.CreatorIdentityID)
                })
                .ToList();
            ViewData["OpeId"] = _userManager.GetUserId(User);
            return View(availCareChats);
        }

        [HttpPost]
        public async Task<JsonResult> DeleteCareChat(string cnId)
        {
            var chats = _repos.GetDataByCustomFilter(p => p.ConnectionId == cnId);//.ForEachAsync(f=>f.IsDeleted = true);
            chats.ForEach(f =>
            {
                f.IsDeleted = true;
                f.LastModifierIdentityID = _userManager.GetUserId(User);
                f.LastModifiedDateAndTime = DateTime.Now;
                f.Lock = false;
                f.LastLockerDate = DateTime.Now;
                f.LastLockerUser = _userManager.GetUserId(User);
            });
            await _repos.UpdateRange(chats);
            return Json(true);
        }

        [HttpPost]
        public async Task<JsonResult> LockCareChat(string cnId)
        {
            try
            {
                var thisUserId = _userManager.GetUserId(User);
                var chats = _repos.GetDataByCustomFilter(p => p.ConnectionId == cnId);
                var orderedList = chats.OrderByDescending(p => p.CreateDateAndTime);
                if (orderedList.Count() == 0)
                    return Json(true);
                var firstChat = orderedList.First();
                if (!firstChat.Lock ||
                    firstChat.LastLockerUser == thisUserId ||
                    (firstChat.Lock && ((DateTime.Now - firstChat.CreateDateAndTime).Hours >= 30)))
                {
                    chats.ForEach(f =>
                    {
                        f.Lock = true;
                        f.LastLockerDate = DateTime.Now;
                        f.LastLockerUser = thisUserId;
                    });
                }
                else
                    return Json(false);
                await _repos.UpdateRange(chats);
                return Json(true);
            }
            catch (Exception ex)
            {
                return Json(false);
            }
        }

        [HttpPost]
        public JsonResult GetCareMessages(string cnId)
        {
            var shamsi = new AvizheCalendar.BLL.WorkingWithPersianCalendar();
            var chats = _repos
                .GetDataByCustomFilter(p => p.ConnectionId == cnId)
                .Select(p => new ChatMessage()
                {
                    MessageText = p.MessageText,
                    MessagePersianDate = shamsi.GregorianToPersian(p.CreateDateAndTime),
                    MessageTime = p.CreateDateAndTime.ToShortTimeString(),
                    Sender = p.CreatorIdentityID
                });
            return Json(chats);
        }

    }
}