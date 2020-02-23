using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtavBlog.Models.Messaging.CustomerCare;
using ArtavBlog.Repository.Base;
using Microsoft.AspNetCore.SignalR;

namespace ArtavBlog.Hubs
{
    public class ChatHub : Hub
    {
        private ISqlBaseRepository<CareMessage> _reposCareMessage;
        public ChatHub(ISqlBaseRepository<CareMessage> reposCareMessage)
        {
            _reposCareMessage = reposCareMessage;
        }
        public async Task GuestSend(string message) // For Customer
        {
            var messageInstance = new CareMessage()
            {
                ID = Guid.NewGuid().ToString(),
                IsDeleted = false,
                CreatorIdentityID = "Guest",
                CreateDateAndTime = DateTime.Now,
                LastModifiedDateAndTime = DateTime.Now,
                LastModifierIdentityID = "Guest",
                ConnectionId = Context.ConnectionId,
                MessageText = message
            };
            var result = await _reposCareMessage.InsertInstance(messageInstance, false);
            await Clients.All.SendAsync("CareReceive", "Guest", Context.ConnectionId, message, messageInstance.ID);
            // await Clients.All.SendAsync("ReceiveMessage", user, message);
        }



        public async Task CareSend(string connectionId, string operatorId/*database user id*/, string message) // For Operator
        {
            var messageInstance = new CareMessage()
            {
                ID = Guid.NewGuid().ToString(),
                IsDeleted = false,
                CreatorIdentityID = operatorId,
                CreateDateAndTime = DateTime.Now,
                LastModifiedDateAndTime = DateTime.Now,
                LastModifierIdentityID = operatorId,
                ConnectionId = Context.ConnectionId,
                MessageText = message
            };
            var result = await _reposCareMessage.InsertInstance(messageInstance, false);
            await Clients.Client(connectionId).SendAsync("GuestReceive", message);
        }

        //public async Task SupportChat(string connectionId, string message)
        //{
        //    await Clients.Client(connectionId).SendAsync("ReceiveMessage",  message);
        //}

        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }
    }
}
