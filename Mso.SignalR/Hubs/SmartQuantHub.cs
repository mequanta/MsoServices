using System;
using System.IO;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;
using System.Collections.Generic;
using SmartQuant;
using System.Reflection;

namespace Mso.SignalR.Hubs
{
    public class SmartQuantHub : Hub
    {
        static SmartQuantHub()
        {
            var framework = new Framework("MeQuanta", FrameworkMode.Simulation, true);
            framework.IsDisposable = false;
            framework.EventLoggerManager.Add(new ConsoleEventLogger(framework));
            framework.GroupDispatcher = new GroupDispatcher(framework);
        }

        public string Start()
        {
            var path = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "../../../SQDemo/bin/Debug/SQDemo.exe"));
            var exe = Assembly.LoadFrom(path);
            Task.Factory.StartNew(() =>
            {
                try
                {
                    exe.EntryPoint.Invoke(null, new object[] { new string[] { "" } });
                    Clients.Caller.StrategyDone();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            });
            return Framework.Current.Name;
        }
    }
}

//        public async Task<IEnumerable<Mso.SignalR.Data.Provider>> GetProviders()
//        {
//            throw new NotImplementedException();
//        }
//
//        public async Task<IEnumerable<Mso.SignalR.Data.Instrument>> GetInstruments()
//        {
//            throw new NotImplementedException();
//        }
//
//        public async Task<Mso.SignalR.Data.Provider> GetProvider(string name)
//        {
//            throw new NotImplementedException();
//        }
//
//        public async Task<Mso.SignalR.Data.Instrument> GetInstrument(string name)
//        {
//            throw new NotImplementedException();
//        }
//
//        public async Task<string> SetProviderPropertiesAsync(string providerName, string jsonProperties)
//        {
//            throw new NotImplementedException();
//        }
//
//        public async Task<string> GetProviderPropertiesAsync(string providerName, string[] names)
//        {
//            throw new NotImplementedException();
//        }
//
//        public async void ConnectProvider(string providerName)
//        {
//            throw new NotImplementedException();
//        }
//
//        public async void DisconnectProvider(string providerName)
//        {
//            throw new NotImplementedException();
//        }
//
//        public async void AddInstrument(Mso.SignalR.Data.Instrument instrument)
//        {
//            throw new NotImplementedException();
//        }
//
//        public async void DeleteInstrument(Mso.SignalR.Data.Instrument instrument)
//        {
//            throw new NotImplementedException();
//        }
//
//        public async void UpdateInstrument(Mso.SignalR.Data.Instrument instrument, string jsonProperties)
//        {
//            throw new NotImplementedException();
//        }
//
//        public async Task<IEnumerable<Mso.SignalR.Data.DataSeries>> GetDataSeriesList()
//        {
//            throw new NotImplementedException();
//        }
//
//        public async Task<IEnumerable<Mso.SignalR.Data.Strategy>> GetStrategies()
//        {
//            throw new NotImplementedException();
//        }
//
//        public async Task<string> StartStrategy(string strategyId)
//        {
//            throw new NotImplementedException();
//        }
//
//        public async Task<string> StopStrategy(string strategyId)
//        {
//            throw new NotImplementedException();
//        }
//
//        public async Task<string> PauseStrategy(string strategyId, string evet)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}

