using Microsoft.AspNetCore.SignalR;

namespace medconnect.API.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(Object usuario, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", usuario, message);
        }
    }
}
