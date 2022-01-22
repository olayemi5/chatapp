
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DarkerPlight.ViewModel;
using Microsoft.AspNetCore.SignalR;



namespace DarkerPlight.Hubs
{
    public class PushNotificationHub : Hub
    {
       public Task SendMessageToAll(string message)
        {
            return Clients.All.SendAsync("RecieveMessage", message);
        }

        public Task SendMessageToCaller(string message)
        {
            return Clients.Caller.SendAsync("RecieveMessage", message);
        }

        public Task SendMessageToUser(string connectionId, string message, string senderId,string username) 
        {
            return Clients.Client(connectionId).SendAsync("RecieveMessage", message,senderId, username);
        }

        public Task JoinGroup(string groupName)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, groupName);
        }

        public Task SendMessageToGroup(string groupName, string message, string sendername, string from)
        {
            return Clients.Groups(groupName).SendAsync("RecieveGroupMessage", message, from, sendername);
        }


        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("UserConnected", Context.ConnectionId, CredentialsVm.Username);
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await Clients.All.SendAsync("UserDisconnected", Context.ConnectionId, CredentialsVm.Username);
            await base.OnDisconnectedAsync(exception);
        }
    }
}
