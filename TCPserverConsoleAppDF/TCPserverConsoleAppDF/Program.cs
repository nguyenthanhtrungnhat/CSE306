using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPserverConsoleAppDF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Address
            Int32 severPort = 30000;
            IPAddress serverIP=IPAddress.Parse("127.0.0.1");

            //Create socket
            TcpListener serverlistener = new TcpListener(serverIP,severPort);

            //Fully add-port so skip bind

            //Create Listen Function
            serverlistener.Start();

            //Waiting for connection
            while (true)
            {
                Console.WriteLine("Waiting for a connection...");
                TcpClient client = serverlistener.AcceptTcpClient();
                Console.WriteLine("Conneted!");

                NetworkStream netStream = client.GetStream();

                byte[] buffer = new byte[256];
                int  recieveData = 0;
             
                while (true)
                {
                    recieveData = netStream.Read(buffer, 0, buffer.Length);
                    if (recieveData == 0){ break;}
                    string s=Encoding.UTF8.GetString(buffer);
                    Console.WriteLine(s);
                }
            }
        }
    }
}
