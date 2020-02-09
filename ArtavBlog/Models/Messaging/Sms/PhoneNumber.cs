using ArtavBlog.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArtavBlog.Models.Messaging.Sms
{
    [Table("PhoneNumber",Schema = "Sms")]
    public class PhoneNumber : ModelObject
    {
        [Required]
        [StringLength(11, MinimumLength = 11)]
        public string Number { get; set; }

        public ICollection<Message> Message_List { get; set; }
    }
}
