using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ArtavBlog.Resources;
using Microsoft.AspNetCore.Identity;

namespace ArtavBlog.Models.Account
{
    [Table("Ident.User")]
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
        }
        [Required]
        public bool IsDeleted { get; set; }

        [StringLength(256)]
        public string Description { get; set; }

        [Required]
        public DateTime CreateDateAndTime { get; set; }

        [Required]
        [StringLength(128)]
        public string CreatorIdentityID { get; set; }

        [Required]
        public DateTime LastModifiedDateAndTime { get; set; }

        [Required]
        [StringLength(128)]
        public string LastModifierIdentityID { get; set; }

    }

    public class ApplicationUserViewModel
    {
        [Display(ResourceType =typeof(TextResources),Name = "APP_STRINGKEYS_Username")]
        public string Username { get; set; }

        [Display(ResourceType = typeof(TextResources), Name = "APP_STRINGKEYS_Username")]
        public string ActivationStatus { get; set; }

        public string Description { get; set; }

        [Display(ResourceType = typeof(TextResources), Name = "APP_STRINGKEYS_RegisterDate")]
        public string SignupShamsiDate { get; set; }

    }

    public class LoginViewModel
    {
        public string ReturnUrl { get; set; }

        [Required]
        [StringLength(256)]
        public string Username { get; set; }


        [Required]
        public string Password { get; set; }
    }

}
