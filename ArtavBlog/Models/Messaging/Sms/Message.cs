using ArtavBlog.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArtavBlog.Models.Messaging.Sms
{
    [Table("Message",Schema ="Sms")]
    public class Message : ModelObject
    {
        [Required]
        [StringLength(256)]
        public string MessageText { get; set; }

        [Required]
        public string PhoneNumberId { get; set; }
        public virtual PhoneNumber PhoneNumber_Message { get; set; }
    }
}
