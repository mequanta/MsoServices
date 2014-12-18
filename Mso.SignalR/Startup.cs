using System;
using Owin;
using Microsoft.AspNet.SignalR;

namespace Mso.SignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR(new HubConfiguration()
            {
                EnableJavaScriptProxies = true,
                EnableDetailedErrors = true
            });
        }
    }
}

