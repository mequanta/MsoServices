using System;
using Microsoft.Owin;
using Microsoft.Owin.Hosting;
using Mso.SignalR;

[assembly: OwinStartup(typeof(WebStartup))]

namespace TestServer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const string url = "http://localhost:8080";
            using (WebApp.Start<WebStartup>("http://localhost:8080"))
            {
                Console.WriteLine("Server running at {0}", url);
                Console.ReadLine();
            } 
        }
    }
}
