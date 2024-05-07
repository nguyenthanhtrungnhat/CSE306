using System;
using System.Net.Sockets;
using System.Text;

Socket socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
socket.Connect("127.0.0.1", 30000);

while (true)
{
    Console.WriteLine("Please enter your input (type 'exit' to quit):");
    string userInput = Console.ReadLine();

    if (userInput.ToLower() == "exit")
    {
        break;
    }

    byte[] requestByte = Encoding.UTF8.GetBytes(userInput);
    int byteSent = 0;
    while (byteSent < requestByte.Length)
    {
        byteSent += socket.Send(requestByte, byteSent, requestByte.Length - byteSent, SocketFlags.None);
    }

    // Reset requestByte and byteSent
    requestByte = null;
}
socket.Close();
