using System;
using System.Collections.Generic;
using System.Drawing;
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
using QRCoder;

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
            return View(_repos.GetDataByCustomFilter(p => !p.IsDeleted));
        }

        public async Task<IActionResult> Create()
        {
            return View(await ViewRequirements());
            async Task<Post> ViewRequirements()
            {
                var itemsList = new List<DropDownItem>();
                itemsList.Add(new DropDownItem()
                {
                    Display = "مطلب معمولی",
                    Value = 0
                });
                itemsList.Add(new DropDownItem()
                {
                    Display = "مطلب اول - صفحه اصلی",
                    Value = 1
                });
                itemsList.Add(new DropDownItem()
                {
                    Display = "مطلب دوم - صفحه اصلی",
                    Value = 2
                });
                itemsList.Add(new DropDownItem()
                {
                    Display = "مطلب سوم - صفحه اصلی",
                    Value = 3
                });
                itemsList.Add(new DropDownItem()
                {
                    Display = "مطلب چهارم - صفحه اصلی",
                    Value = 4
                });
                ViewData["OrderList"] = new SelectList(itemsList, "Value", "Display");
                return new Post()
                {
                    ID = Guid.NewGuid().ToString()
                };
            }
        }

        public async Task<IActionResult> Details(string postId)
        {
            await ViewRequirements();
            return View("Create", _repos.GetSingleDataById(postId));
            async Task ViewRequirements()
            {
                var itemsList = new List<DropDownItem>();
                itemsList.Add(new DropDownItem()
                {
                    Display = "مطلب معمولی",
                    Value = 0
                });
                itemsList.Add(new DropDownItem()
                {
                    Display = "مطلب اول - صفحه اصلی",
                    Value = 1
                });
                itemsList.Add(new DropDownItem()
                {
                    Display = "مطلب دوم - صفحه اصلی",
                    Value = 2
                });
                itemsList.Add(new DropDownItem()
                {
                    Display = "مطلب سوم - صفحه اصلی",
                    Value = 3
                });
                itemsList.Add(new DropDownItem()
                {
                    Display = "مطلب چهارم - صفحه اصلی",
                    Value = 4
                });
                ViewData["OrderList"] = new SelectList(itemsList, "Value", "Display");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Search(string q)
        {
            return View("Index", _repos.GetDataByCustomFilter(p => !p.IsDeleted &&
             (p.Title.Contains(q) || p.ContentInBrief.Contains(q) || p.ContentHtml.Contains(q))
            ));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Post dataPost)
        {
            await ViewRequirements();
            if (!_repos.GetDataByCustomFilter(p => !p.IsDeleted && p.ID == dataPost.ID).Any())
            {
                if (await _repos.InsertInstance(dataPost, false))
                    return RedirectToAction("Index", new { messageId = MessageId.Success });
                else
                    return RedirectToAction("Index", new { messageId = MessageId.Failure });
            }
            else
            {
                if (await _repos.UpdateInstance(dataPost))
                    return RedirectToAction("Index", new { messageId = MessageId.Success });
                else
                    return RedirectToAction("Index", new { messageId = MessageId.Failure });
            }

            async Task ViewRequirements()
            {
                dataPost.CreateDateAndTime = DateTime.Now;
                dataPost.LastModifiedDateAndTime = DateTime.Now;
                dataPost.IsDeleted = false;
                dataPost.LastModifierIdentityID = Guid.NewGuid().ToString();// User.Identity.Name;
                dataPost.CreatorIdentityID = Guid.NewGuid().ToString();// User.Identity.Name;
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
                    string savePath = string.Format("{0}/images/Post/{1}", pathWeb, postId);
                    if (!Directory.Exists(savePath))
                        Directory.CreateDirectory(savePath);
                    string savePathFull = string.Format("{0}/{1}", savePath, file.FileName);
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

        public IActionResult Post(string postId)
        {
            var instanceMain = _repos.GetSingleDataById(postId);
            var instanceSend = new PostViewModel()
            {
                ID = instanceMain.ID,
                ContentHtml = instanceMain.ContentHtml,
                ContentInBrief = instanceMain.ContentInBrief,
                Title = instanceMain.Title,
                PostPictureName = instanceMain.PostPictureName,
                LastModifiedDateAndTime = instanceMain.LastModifiedDateAndTime
            }; 
            instanceSend.Barcode = GetPostBrcode();
            return View(instanceSend);
            Byte[] GetPostBrcode()
            {
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                ViewData["Url"] = Microsoft.AspNetCore.Http.Extensions.UriHelper.GetDisplayUrl(Request);
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(ViewData["Url"].ToString(),
                QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(20);
                return GetImageBytesByBitmap(qrCodeImage);
                Byte[] GetImageBytesByBitmap(Bitmap img)
                {
                    using (MemoryStream stream = new MemoryStream())
                    {
                        img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                        return stream.ToArray();
                    }
                }
            }

        }
    }
}