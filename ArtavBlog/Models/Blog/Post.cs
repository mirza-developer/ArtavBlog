using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ArtavBlog.Models.Base;
using ArtavBlog.Resources;

namespace ArtavBlog.Models.Blog
{
    [Table("Post",Schema = "Blog")]
    public class Post : ModelObject
    {
        [Required]
        [StringLength(128)]
        [Display(Name = "عنوان پست")]
        public string Title { get; set; }

        [Display(Name = "اولویت پست")]
        public int PostOrder { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UniqueIntegerID { get; set; }

        [Required]
        [Display(Name = "متن")]
        public string ContentHtml { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "خلاصه مطلب")]
        public string ContentInBrief { get; set; }

        [Required]
        [Display(Name = "عکس اصلی مطلب")]
        public string PostPictureName { get; set; }

        
        public virtual ICollection<TagPost> TagPost_List { get; set; }
        public virtual ICollection<Comment> Comment_List { get; set; }
    }

    public class PostViewModel
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string ContentHtml { get; set; }
        public string ContentInBrief { get; set; }
        public string PostPictureName { get; set; }
        public DateTime LastModifiedDateAndTime { get; set; }
        public Byte[] Barcode { get; set; }
    }
}
