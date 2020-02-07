﻿using System;
using System.Collections.Generic;
using System.IO;
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
            if (await _repos.InsertInstance(dataPost, false))
                return RedirectToAction("Index", new { messageId = MessageId.Success });
            else
                return RedirectToAction("Index", new { messageId = MessageId.Failure });
            async Task ViewRequirements()
            {
                dataPost.CreateDateAndTime = DateTime.Now;
                dataPost.LastModifiedDateAndTime = DateTime.Now;
                dataPost.IsDeleted = false;
                dataPost.LastModifierIdentityID = Guid.NewGuid().ToString();// User.Identity.Name;
                dataPost.CreatorIdentityID = Guid.NewGuid().ToString();// User.Identity.Name;
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
                    string savePath = string.Format("{0}/images/Post/{1}", pathWeb,postId);
                    if (!Directory.Exists(savePath))
                        Directory.CreateDirectory(savePath);
                    string savePathFull = string.Format("{0}/{1}" , savePath, file.FileName);
                    if (System.IO.File.Exists(savePathFull))
                        System.IO.File.Delete(savePathFull);
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