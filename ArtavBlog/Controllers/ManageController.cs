using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ArtavBlog.Controllers
{
    public class ManageController : Controller
    {
        public IActionResult CareChat()
        {
            return View();
        }
    }
}