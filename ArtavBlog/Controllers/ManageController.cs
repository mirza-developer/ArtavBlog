using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtavBlog.Models.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ArtavBlog.Controllers
{
    public class ManageController : Controller
    {
        private BlogContext _context;
        public ManageController(BlogContext context)
        {
            _context = context;
        }
        public IActionResult CareChat()
        {
            var availCareChats = _context.CareMessageDb.FromSqlRaw("Select Distinct CareMessage.ID, CareMessage.CreatorIdentityID,CareMessage.ConnectionId,(Select top(1) CareMessage.CreateDateAndTime Order by CareMessage.CreateDateAndTime DESC) as [CreateDateAndTime] from SignalR.CareMessage WHERE CareMessage.IsDeleted = 0").ToList();
            return View();
        }
    }
}