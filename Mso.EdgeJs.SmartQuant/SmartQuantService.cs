using System;
using System.Threading.Tasks;

namespace Mso.EdgeJs
{
    public class SmartQuantService
    {
        public async Task<string> GetProviderListAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetProviderAsync(string providerName)
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

        public async void GetInstrumentListAsync()
        {
            throw new NotImplementedException();
        }

        public async void AddInstrumentsAsync(string jsonText)
        {
            throw new NotImplementedException();
        }

        public async void DeleteInstrumentsAsync(string[] names)
        {
            throw new NotImplementedException();
        }

        public async void UpdateInstrumentAsync(string names, string jsonProperties)
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetDataSeriesListAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetStrategyListAsync()
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
