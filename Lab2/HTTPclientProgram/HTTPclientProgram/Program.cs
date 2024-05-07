using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;


namespace HTTPclientProgram
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            //    string result = await client.GetStringAsync("http://example.com/");
            string result = await client.GetStringAsync("https://timkiem.vnexpress.net/?q=iphone x");
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
