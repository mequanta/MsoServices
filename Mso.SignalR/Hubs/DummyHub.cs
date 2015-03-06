using Microsoft.AspNet.SignalR;

namespace Mso.SignalR.Hubs
{
    public class DummyHub : Hub
    {
        public void Say(string message)
        {
            Clients.Caller.sayBack(string.Format("{0} back", message));
        }
    }
}
