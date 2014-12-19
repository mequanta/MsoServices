using System;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Hubs;

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

    [HubName("CustomHub")]
    public class MyHub : Hub {
        public string Send(string message) {
            return message;
        }

        public void DoSomething(string param) {
            Clients.Caller.addMessage(param);
        }
    }

    public class HelloWorld : Hub 
    {
        public void Hello()
        {
            Clients.All.hello();
        }        
    }
}
