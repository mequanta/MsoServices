using System;
using Gtk;

namespace Mso.SignalR.SharpClient
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string url = args.Length == 1 ? args[0] : "http://localhost:8118/signalr";
            Application.Init();
            MainWindow win = new MainWindow(url);
            win.Show();
            Application.Run();
        }
    }
}
