using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace ArtavBlog.Controllers
{
    public class SettingController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        public SettingController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult GetImageByUrl(string imageUrl)
        {
            imageUrl = imageUrl.Replace("/", "\\").Replace("~", "");
            string pathWeb = _hostingEnvironment.WebRootPath + imageUrl;
            var image = Image.FromFile(pathWeb);
            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return File(ms.ToArray(), "image/png");
            }
        }

    }
}