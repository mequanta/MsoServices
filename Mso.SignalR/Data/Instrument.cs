namespace Mso.SignalR.Data
{
    public class Instrument
    {
    }

    public class Provider
    {
    }

    public class DataSeries
    {
    }

    public class Strategy
    {
    }

    public class Solution
    {
        public string Name { get; set; }

        public string Type { get; private set; }

        public Solution()
        {
            Type = "solution";
        }
    }
}

