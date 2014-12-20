using System;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Hubs;

namespace Mso.SignalR.Hubs
{
    public class SmartQuantHub : Hub<ISmartQuantService>
    {
    }
}

