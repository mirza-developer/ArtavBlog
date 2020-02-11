using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace ArtavBlog.Hubs
{
    public class ChatHub : Hub
    {
        public async Task WebChat(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public async Task SupportChat(string connectionId, string message)
        {
            await Clients.Client(connectionId).SendAsync("ReceiveMessage",  message);
        }

        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }
    }
}
