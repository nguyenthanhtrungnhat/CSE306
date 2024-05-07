using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace demoLTG
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            string results = await client.GetStringAsync("http://example.com");
            Console.WriteLine(results);
        }
    }
}
