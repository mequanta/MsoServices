using System;
using Gtk;
using Microsoft.AspNet.SignalR.Client;

public partial class MainWindow: Gtk.Window
{
    private string url;

    private Connection connection;

    public MainWindow(string url)
        : base(Gtk.WindowType.Toplevel)
    {
        Build();
        this.url = url;
        this.connection = new Connection(this.url);
        this.connection.Start().Wait();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        this.connection.Stop();
        Application.Quit();
        a.RetVal = true;
    }

    protected void GetProvidersInfo(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
}
