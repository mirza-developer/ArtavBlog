using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtavBlog.Business.Base;
using ArtavBlog.Models.Base;
using ArtavBlog.Models.Blog;
using ArtavBlog.Repository.Base;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ArtavBlog.Controllers
{
    public class BlogController : Controller
    {
        private ISqlBaseRepository<Post> _repos;
        private readonly IHostingEnvironment _hostingEnvironment;
        public BlogController(ISqlBaseRepository<Post> repos, IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            _repos = repos;
        }

        public IActionResult Index(MessageId messageId = MessageId.NoAction)
        {
            return View(_repos.GetAllData());
        }

        public async Task<IActionResult> Create()
        {

            return View(await ViewRequirements());
            async Task<Post> ViewRequirements()
            {
                var itemsList = new List<DropDownItem>();
                for (int i = 0; i <= 4; i++)
                {
                    itemsList.Add(new DropDownItem()
                    {
                        Display = i.ToString(),
                        Value = i
                    });
                }
                ViewData["OrderList"] = new SelectList(itemsList, "Value", "Display");
                return new Post()
                {
                    ID = Guid.NewGuid().ToString()
                };
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Post dataPost)
        {
            await ViewRequirements();
            if (await _repos.InsertInstance(dataPost, true))
                return RedirectToAction("Index", new { messageId = MessageId.Success });
            else
                return RedirectToAction("Index", new { messageId = MessageId.Failure });
            async Task ViewRequirements()
            {
                dataPost.LastModifierIdentityID = User.Identity.Name;
                dataPost.CreatorIdentityID = User.Identity.Name;
                dataPost.PostPictureName = string.Empty;
            }
        }

        [HttpPost]
        public async Task<IActionResult> UploadMainPicture(IFormFile file, string postId)
        {
            try
            {
                if (file != null && file.Length > 0)
                {
                    string pathWeb = _hostingEnvironment.WebRootPath;
                    string savePathFull = string.Format("/images/Post/{0}/{1}/{2}", postId, pathWeb, file.FileName);
                    using var stream = System.IO.File.Create(savePathFull);
                    await file.CopyToAsync(stream);
                    return Json(true);
                }
                else
                {
                    return Json(false);
                }
            }
            catch (Exception ex)
            {
                return Json(false);
            }
        }
    }
}