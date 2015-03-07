using Microsoft.AspNet.SignalR;

namespace Mso.SignalR.Hubs
{
    public class RoslynHub : Hub
    {
        public string GetSolutionInDirectory(string workspaceDir)
        {
            return "{}";
        }
    }
}

