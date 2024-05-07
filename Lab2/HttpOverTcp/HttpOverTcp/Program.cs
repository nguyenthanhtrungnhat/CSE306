using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HttpOverTcp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Uri uri = new Uri("http://example.com");
            byte[] requestBytes = Encoding.ASCII.GetBytes($@"GET {uri.AbsoluteUri} HTTP/1.1
Host: {uri.Host}
Connection: Open

");


            TcpClient client = new TcpClient(uri.Host, 80);


            NetworkStream ns = client.GetStream();

           
            while (true)
            {
                ns.Write(requestBytes, 0, requestBytes.Length);
                byte[] responseBytes = new Byte[4096];
                int thisRead ;      
                while ((thisRead = ns.Read(responseBytes, 0, responseBytes.Length)) > 0)
                {
                    string response = Encoding.ASCII.GetString(responseBytes, 0, thisRead);
                    Console.Write(response);
                   
                }
              client.Close();
            }

        }
}
}
