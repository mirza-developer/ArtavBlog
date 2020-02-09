using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ArtavBlog.Models.Base;

namespace ArtavBlog.Models.Blog
{
    [Table("TagPost", Schema = "Blog")]
    public class TagPost : ModelObject
    {
        public string PostId { get; set; }
        public virtual Post Post_TagPost { get; set; }

        public string TagId { get; set; }
        public virtual Tag Tag_TagPost { get; set; }
    }
}
