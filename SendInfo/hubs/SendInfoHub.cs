using Microsoft.AspNet.SignalR;

namespace SendInfo.hubs
{
    public class SendInfoHub : Hub
    {
        public void SendAll(string Info)
        {
            Clients.Others.addinfo(Info);
        }
    }
}