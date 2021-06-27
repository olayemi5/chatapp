using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DarkerPlight.Hubs
{
    public interface IPushNotification
    {
        Task onMessageSent(string MessageSent);
        Task onMessageReceived(string MessageReceived);
        Task SendAsync(string MessageSent,string MessageReceived);
    }
}
