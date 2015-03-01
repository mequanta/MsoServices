using System;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Client;

namespace TestClient
{
    public class Client
    {
        private TextWriter traceWriter;

        public Client(TextWriter traceWriter)
        {
            this.traceWriter = traceWriter;
        }

        public async Task RunAsync(string url)
        {
            try
            {
                await RunDemo(url);
            }
            catch (HttpClientException httpClientException)
            {
                traceWriter.WriteLine("HttpClientException: {0}", httpClientException.Response);
                throw;
            }
            catch (Exception exception)
            {
                traceWriter.WriteLine("Exception: {0}", exception);
                throw;
            }
        }

        private async Task RunDemo(string url)
        {
            var hubConnection = new HubConnection(url);
            hubConnection.TraceWriter = this.traceWriter;

            var hubProxy = hubConnection.CreateHubProxy("demo");
            hubProxy.On<int>("invoke", (i) =>
            {
                int n = hubProxy.GetValue<int>("index");
                hubConnection.TraceWriter.WriteLine("{0} client state index -> {1}", i, n);
            });
            await hubConnection.Start();
            hubConnection.TraceWriter.WriteLine("transport.Name={0}", hubConnection.Transport.Name);
        }
    }
}

