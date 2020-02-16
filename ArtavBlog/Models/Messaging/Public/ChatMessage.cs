using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtavBlog.Models.Messaging.Public
{
    public class ChatMessage
    {
        public string Sender { get; set; }
        public string MessageText { get; set; }
        public DateTime SendDateAndTime { get; set; }
    }
}
