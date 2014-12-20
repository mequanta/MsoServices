using System;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Hubs;
using System.Collections.Generic;
using Mso.SignalR.Data;

namespace Mso.SignalR.Hubs
{
    public class SmartQuantHub : Hub<ISmartQuantService>
    {
        public async Task<IEnumerable<Provider>> GetProviders()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Instrument>> GetInstruments()
        {
            throw new NotImplementedException();
        }

        public async Task<Provider> GetProvider(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<Instrument> GetInstrument(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<string> SetProviderPropertiesAsync(string providerName, string jsonProperties)
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetProviderPropertiesAsync(string providerName, string[] names)
        {
            throw new NotImplementedException();
        }

        public async void ConnectProvider(string providerName)
        {
            throw new NotImplementedException();
        }

        public async void DisconnectProvider(string providerName)
        {
            throw new NotImplementedException();
        }

        public async void AddInstrument(Instrument instrument)
        {
            throw new NotImplementedException();
        }

        public async void DeleteInstrument(Instrument instrument)
        {
            throw new NotImplementedException();
        }

        public async void UpdateInstrument(Instrument instrument, string jsonProperties)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<DataSeries>> GetDataSeriesList()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Strategy>> GetStrategies()
        {
            throw new NotImplementedException();
        }

        public async Task<string> StartStrategy(string strategyId)
        {
            throw new NotImplementedException();
        }

        public async Task<string> StopStrategy(string strategyId)
        {
            throw new NotImplementedException();
        }

        public async Task<string> PauseStrategy(string strategyId, string evet)
        {
            throw new NotImplementedException();
        }
    }
}

