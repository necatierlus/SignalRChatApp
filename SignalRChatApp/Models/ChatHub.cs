using Microsoft.AspNet.SignalR;

namespace SignalRChatApp.Models
{
    public class ChatHub : Hub
    {
        public void Send(string username, string message)
        {
           Clients.All.sendMessage(username, message);
        }
    }
}