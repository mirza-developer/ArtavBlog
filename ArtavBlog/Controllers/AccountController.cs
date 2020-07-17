using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ArtavBlog.Business.Base;
using ArtavBlog.Controllers.Base;
using ArtavBlog.Hubs;
using ArtavBlog.Models.Account;
using ArtavBlog.Models.Base;
using ArtavBlog.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ArtavBlog.Controllers
{
    [Authorize]
    public class AccountController : ParentController
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly BlogContext _context;
        public AccountController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userInManager, BlogContext context)
        {
            _signInManager = signInManager;
            _userManager = userInManager;
            _context = context;
        }


        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View(_context.Roles.ToList());
        }



        [Authorize]
        public async Task<IActionResult> Profile()
        {
            return View(await _userManager.GetUserAsync(User));
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> RoleDetail(string role)
        {
            var rolesById = _context.UserRoles
            .Where(w => w.RoleId == role);
            if (!rolesById.Any())
                return View(new List<ApplicationUser>());
            ViewData["Title"] = $"کاربران سطح دسترسی {(await _context.Roles.FirstOrDefaultAsync()).NormalizedName}";
            return View(rolesById
            .Join(_context.Users, ur => ur.UserId, u => u.Id,
                (ur, u) => u));
        }

        [AllowAnonymous]
        public IActionResult Login(string returnUrl, MessageId messageId = MessageId.NoAction)
        {
            //ViewData["ReturnUrl"] = returnUrl;
            return View(new LoginViewModel()
            {
                ReturnUrl = returnUrl
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel login, string returnUrl)
        {
            var user = await _context.Users.FirstOrDefaultAsync(p => p.UserName == login.Username); ;
            if (user is null)
            {
                ModelState.AddModelError("", TextResources.APP_STRINGKEYS_Message_LoginFailed);
                return RedirectToAction("Login", new { returnUrl = returnUrl, messageId = MessageId.LoginFailed });
            }
            if (user.IsDeleted)
            {
                ModelState.AddModelError("", TextResources.APP_STRINGKEYS_Message_Suspend);
                return RedirectToAction("Login", new { returnUrl = returnUrl, messageId = MessageId.LoginFailed });
            }
            var result = await _signInManager.PasswordSignInAsync(user, login.Password, false, false);
            if (result.Succeeded)
                if (string.IsNullOrEmpty(returnUrl))
                    return Redirect("/");
                else
                    return Redirect(returnUrl);
            else
            {
                ModelState.AddModelError("", TextResources.APP_STRINGKEYS_Message_LoginFailed);
                return RedirectToAction("Login", new { returnUrl = returnUrl, messageId = MessageId.LoginFailed });
            }
        }

        [HttpPost]
        public async Task<IActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }

    }
}