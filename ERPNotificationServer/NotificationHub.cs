using Microsoft.AspNetCore.SignalR;

namespace ERPNotificationServer
{
    public class ERPNotificationHub : Hub
    {
        public async Task SendNotification(string message)
        {
            await Clients.All.SendAsync("ReceiveNotification", message);
        }
    }

}