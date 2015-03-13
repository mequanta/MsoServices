using Owin;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.StaticFiles;
using Microsoft.Owin;
using Microsoft.Owin.FileSystems;

namespace Mso.SignalR
{
    public class WebStartup
    {
        private string wwwroot;

        public WebStartup(string wwwroot = null)
        {
            this.wwwroot = wwwroot;
        }

        public void Configuration(IAppBuilder app)
        {
            app.Properties["host.AppName"] = "Mso";
            app.MapSignalR(new HubConfiguration()
            {
                EnableJavaScriptProxies = true,
                EnableDetailedErrors = true
            });
            app.UseFileServer(new FileServerOptions()
            {
                RequestPath = PathString.Empty,
                FileSystem = new PhysicalFileSystem(this.wwwroot ?? "../../../NodeServer/www")
            });
        }
    }
}

