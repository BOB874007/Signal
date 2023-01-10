using Microsoft.AspNetCore.SignalR;
namespace SignalRServer.Hubs
{
    public class StringHub : Hub
    {
        public async Task SendStringToAllClients()
        {
            await Clients.All.SendAsync("showString", "Przykładowy teks");
        }
    }
}
