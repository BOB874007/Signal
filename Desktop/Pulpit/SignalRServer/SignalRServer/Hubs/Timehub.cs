using Microsoft.AspNetCore.SignalR;
namespace SignalRServer.Hubs
{
    public class TimeHub : Hub
    {
        public DateTime GetCurrentDateTime()
    {
            return DateTime.UtcNow;
    }
    }
}
