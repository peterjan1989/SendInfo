using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SendInfo.Startup))]
namespace SendInfo
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}