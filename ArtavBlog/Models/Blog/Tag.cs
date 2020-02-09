using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ArtavBlog.Models.Base;

namespace ArtavBlog.Models.Blog
{
    [Table("Tag", Schema = "Blog")]
    public class Tag : ModelObject
    {
        [Required]
        [StringLength(128)]
        public string Title { get; set; }
        public virtual ICollection<TagPost> TagPost_List { get; set; }
    }
}
