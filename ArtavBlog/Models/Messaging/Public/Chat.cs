using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtavBlog.Models.Messaging.Public
{
    public class Chat
    {
        public string ConnectionId { get; set; }
        public string LastMessageTime { get; set; }
        public string LastMessagePersianDate { get; set; }
        public string LastMessageText { get; set; }
        public string SenderName { get; set; }
        public List<ChatMessage> MessageList { get; set; }
    }
}
