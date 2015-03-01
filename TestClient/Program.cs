using System;

namespace TestClient
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var url = args.Length > 0 ? args[0] : "http://localhost:8080";
            var client = new Client(Console.Out);
            client.RunAsync(url).Wait();
            Console.ReadKey();
        }
    }
}
