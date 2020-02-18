using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtavBlog.Models.Account;
using ArtavBlog.Models.Base;
using ArtavBlog.Models.Messaging.CustomerCare;
using ArtavBlog.Models.Messaging.Public;
using ArtavBlog.Repository.Base;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ArtavBlog.Controllers
{
    public class ManageController : Controller
    {
        //     private BlogContext _context;
        private ISqlBaseRepository<CareMessage> _repos;
        private UserManager<ApplicationUser> _userManager;
        public ManageController(ISqlBaseRepository<CareMessage> repos , UserManager<ApplicationUser> userManager)
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
                " [Ranking] from SignalR.CareMessage) as Nested WHERE Nested.Ranking =1) ")
                .Select(p => new Chat()
                {
                    ConnectionId = p.ConnectionId,
                    LastMessageText = p.MessageText.Length > 20 ? (p.MessageText.Substring(0, 20) + " ..") : p.MessageText,
                    LastMessagePersianDate = calendar.GregorianToPersian(p.CreateDateAndTime),
                    LastMessageTime = p.CreateDateAndTime.ToShortTimeString(),
                    SenderName = p.CreatorIdentityID
                })
                .ToList();
            return View(availCareChats);
        }

        [HttpPost]
        public async Task<JsonResult> DeleteCareChat(string cnId)
        {
            var chats = _repos.GetDataByCustomFilter(p => p.ConnectionId == cnId);//.ForEachAsync(f=>f.IsDeleted = true);
            chats.ForEach(f =>
            {
                f.IsDeleted = true;
                f.LastModifierIdentityID = (User.Identity.IsAuthenticated ? _userManager.GetUserId(User) : string.Empty);
                f.LastModifiedDateAndTime = DateTime.Now;
            });
            await _repos.UpdateRange(chats);
            return Json(true);
        }
    }
}