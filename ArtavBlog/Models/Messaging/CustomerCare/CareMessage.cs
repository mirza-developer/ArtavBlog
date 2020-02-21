using ArtavBlog.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArtavBlog.Models.Messaging.CustomerCare
{
    [Table("CareMessage",Schema ="SignalR")]
    public class CareMessage : ModelObject
    {
        [Required]
        [StringLength(300)]
        public string MessageText  { get; set; }

        public string ConnectionId { get; set; }

        [Required]
        public bool Lock { get; set; }

        [StringLength(128)]
        public string LastLockerUser { get; set; }

        public DateTime? LastLockerDate { get; set; }
    }
}
