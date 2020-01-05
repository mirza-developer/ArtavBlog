using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ArtavBlog.Models.Base;

namespace ArtavBlog.Models.Blog
{
    [Table("Blog.Comment")]
    public class Comment : ModelObject
    {
        [Required]
        [StringLength(128)]
        public string Sender { get; set; }

        [Required]
        [StringLength(512)]
        public string Text { get; set; }

        [Required]
        [StringLength(128)]
        public string PostId { get; set; }
        public virtual Post Post_Comment { get; set; }

        public bool? IsVerified { get; set; }


    }
}
