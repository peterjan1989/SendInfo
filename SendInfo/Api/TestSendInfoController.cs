using Microsoft.AspNet.SignalR;
using SendInfo.hubs;
using System.Web.Http;

namespace SendInfo.Api
{
    public class TestSendInfoController : ApiController
    {
        [HttpGet]
        public string TrySendInfo(string Info)
        {
            //Demo: http://localhost:62674/api/TestSendInfo/TrySendInfo?Info=XXXX

            var hub = GlobalHost.ConnectionManager.GetHubContext<SendInfoHub>();
            hub.Clients.All.addinfo(Info);

            return string.Empty;
        }
    }
}
