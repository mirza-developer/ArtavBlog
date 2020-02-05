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
    [Table("Blog.Post")]
    public class Post : ModelObject
    {
        [Required]
        [StringLength(128)]
        [Display(Name = "Post_Field_Title", ResourceType = typeof(TextResources))]
        public string Title { get; set; }

        [Display(Name = "Post_Field_IsMain", ResourceType = typeof(TextResources))]
        public int PostOrder { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UniqueIntegerID { get; set; }

        [Required]
        [Display(Name = "Post_Field_Content", ResourceType = typeof(TextResources))]
        public string ContentHtml { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Post_Field_BriefContent", ResourceType = typeof(TextResources))]
        public string ContentInBrief { get; set; }

        [Required]
        [Display(Name = "Post_Field_PostPicture", ResourceType = typeof(TextResources))]
        public string PostPictureName { get; set; }

        public virtual ICollection<TagPost> TagPost_List { get; set; }
        public virtual ICollection<Comment> Comment_List { get; set; }
    }

    public class PostViewModel
    {
        [Required]
        [StringLength(128)]
        public string Title { get; set; }

        [Required]
        public string ContentHtml { get; set; }

        [Required]
        public string PostPictureLocation { get; set; }

        public int IsMainPost { get; set; }
    }
}
