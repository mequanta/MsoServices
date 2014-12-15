using System.Threading.Tasks;

namespace Mso.EdgeJs
{
    public class Startup
    {
        public async Task<object> Invoke(dynamic input)
        {
            string service = input.service as string;
            string method = input.method as string;
            var args = input.args as object[];
            if (service == "Dummy" && method == "GetInfo")
            {
                return await DummyService.Current.GetInfoAsync();
            }
            return null;
        }
    }
}

