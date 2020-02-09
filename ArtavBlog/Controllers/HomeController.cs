using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ArtavBlog.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ArtavBlog.Models;
using ArtavBlog.Models.Base;
using Microsoft.AspNetCore.Authorization;
using ArtavBlog.Models.Blog;
using ArtavBlog.Repository.Base;
using ArtavBlog.Models.Messaging.Sms;

namespace ArtavBlog.Controllers
{
    public class HomeController : ParentController
    {
        private ISqlBaseRepository<Post> _reposPost;
        private ISqlBaseRepository<PhoneNumber> _reposNumber;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ISqlBaseRepository<Post> reposPost, ISqlBaseRepository<PhoneNumber> reposNumber)
        {
            _logger = logger;
            _reposPost = reposPost;
            _reposNumber = reposNumber;
        }

        public IActionResult Index()
        {
            return View(_reposPost.GetDataByCustomFilter(p=> ! p.IsDeleted && p.PostOrder != 0));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public async Task<IActionResult> AddPhone(string phoneNumber)
        {
            if (!_reposNumber.GetDataByCustomFilter(p => p.Number == phoneNumber).Any())
            {
                var phone = new PhoneNumber()
                {
                    ID = Guid.NewGuid().ToString(),
                    IsDeleted = false,
                    CreatorIdentityID = "Anonym",
                    CreateDateAndTime = DateTime.Now,
                    LastModifiedDateAndTime = DateTime.Now,
                    LastModifierIdentityID = "Anonym",
                    Number = phoneNumber
                };
                if (await _reposNumber.InsertInstance(phone,false))
                    return Json(true);
                else
                    return Json(false);
            }
            else
                return Json(true);

        }
    }
}
