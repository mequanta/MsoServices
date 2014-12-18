using System;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace Mso.SignalR
{
    public class DummyConnection : PersistentConnection
    {
        protected override Task OnReceived(IRequest request, string connectionId, string data)
        {
            return Connection.Broadcast(data);
        }
    }

    public class DummyHub : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.addMessage(name, message);
        }
    }
}
