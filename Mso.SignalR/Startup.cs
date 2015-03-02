using System;
using Owin;
using Microsoft.AspNet.SignalR;
using System.Collections.Generic;

namespace Mso.SignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // This property must be set because 
            // DataProtectionProviderProtectedData need it to an constant instanceName 
            // argument. See line 200 in file Owin/OwinExtentions in SignalR core package.
            app.Properties["host.AppName"] = "Mso";
            app.MapSignalR(new HubConfiguration()
            {
                EnableJavaScriptProxies = true,
                EnableDetailedErrors = true
            });
        }
    }
}
