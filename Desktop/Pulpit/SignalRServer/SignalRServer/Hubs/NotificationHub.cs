using Microsoft.AspNetCore.SignalR;
namespace SignalRServer.Hubs
{
    public class NotificationHub : Hub
    {
        public void SendMessageToAllClients(string username, string message)
        {

            Clients.All.SendAsync("ShowMessage", username, message);

        }
    }
}
