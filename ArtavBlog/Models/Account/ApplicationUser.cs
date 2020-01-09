using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ArtavBlog.Models.Account
{
    [Table("Ident.User")]
    public class ApplicationUser : IdentityUser
    {
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
