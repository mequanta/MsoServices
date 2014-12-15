using System;
using System.Threading.Tasks;

namespace Mso.EdgeJs
{
    public class DummyService
    {
        public int Counter { get; set; }

        private static DummyService myClass;

        public static DummyService Current
        {
            get
            {
                if (myClass == null)
                    myClass = new DummyService();
                return myClass;
            }
        }

        public DummyService()
        {
            Counter = 0;
            DummyService.myClass = DummyService.myClass ?? this;
        }

        public async Task<string> GetInfoAsync()
        {
            return await Task.FromResult<string>(string.Format("DummyService with Call Count: {0}", Counter++));
        }
    }
}

