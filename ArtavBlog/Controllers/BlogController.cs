using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtavBlog.Models.Blog;
using Microsoft.AspNetCore.Mvc;

namespace ArtavBlog.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View(new List<Post>());
        }
    }
}