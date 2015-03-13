using System;
using System.Collections.Generic;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Microsoft.Owin;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.Hosting;
using Microsoft.Owin.StaticFiles;
using Mono.Options;
using Mso.SignalR;
using Owin;
                                                                                                                                                                                                                                                    
[assembly: OwinStartup(typeof(WebStartup))]

namespace TestServer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string host = "localhost";
            int port = 8080;
            string wwwroot = "../../../NodeServer/www";

            string data = null;
            bool help = false;
            int verbose = 0;

            var p = new OptionSet()
            {
                { "h|host",  v => host = v  },
                { "p|port=",  (int v) => port = v },
                { "w|wwwroot", v => wwwroot = v }
            };
            p.Parse(args);
            string url = string.Format("http://{0}:{1}", host, port);
            var options = new StartOptions(url);
            options.Settings["wwwroot"] = wwwroot;
           
            using (WebApp.Start<WebStartup>(options))
            {
                Console.WriteLine("Server running at {0}", url);
                Console.ReadLine();
            }

//            using (WebApp.Start(url, app =>
//            {
//                app.Properties["host.AppName"] = "Mso";
//                app.MapSignalR(new HubConfiguration()
//                {
//                    EnableJavaScriptProxies = true,
//                    EnableDetailedErrors = true
//                });
//                app.UseFileServer(new FileServerOptions()
//                {
//                    RequestPath = PathString.Empty,
//                    FileSystem = new PhysicalFileSystem(wwwroot)
//                });
//                app.UseWelcomePage(); 
//            }))
//            {
//                Console.WriteLine("Server running at {0}", url);
//                Console.ReadLine();
//            }
        }
    }
}
