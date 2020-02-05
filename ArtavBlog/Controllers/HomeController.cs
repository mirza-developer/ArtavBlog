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

namespace ArtavBlog.Controllers
{
    public class HomeController : ParentController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,BlogContext context)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(new List<Post>());
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
    }
}
