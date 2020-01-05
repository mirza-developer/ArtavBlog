using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ArtavBlog.Models.Account
{
    public class ApplicationRole : IdentityRole
    {
        [Required]
        [StringLength(256)]
        public string NameInPersian { get; set; }

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
}
