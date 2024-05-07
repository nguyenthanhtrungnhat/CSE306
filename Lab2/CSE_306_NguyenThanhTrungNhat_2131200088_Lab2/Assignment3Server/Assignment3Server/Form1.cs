using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Assignment3Server
{
    public partial class Form1 : Form
    {
        TcpListener server;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnListen_Click(object sender, EventArgs e)
        {
            server = new TcpListener(IPAddress.Any, 20000);
            server.Start();
            lbContent.Items.Add("Waiting for connection...");

            Thread t = new Thread(Listen);
            t.Start();
        }

        private void Listen()
        {
            Byte[] buffer = new Byte[1024 * 1024]; // 1 MB buffer for receiving image data

            while (true)
            {
                try
                {
                    TcpClient client = server.AcceptTcpClient();
                    lbContent.Invoke(new Action(() =>
                    {
                        lbContent.Items.Add("Connected!" + Environment.NewLine);
                    }));

                    NetworkStream ns = client.GetStream();

                    // Get the original filename provided by the client
                    string receivedFileName = Path.Combine(Path.GetFileName(Path.GetRandomFileName()) + ".jpg");

                    // Open a file stream to save the received image data
                    using (FileStream fs = File.Create(receivedFileName))
                    {
                        int bytesRead;
                        while ((bytesRead = ns.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            // Write the received bytes to the file stream
                            fs.Write(buffer, 0, bytesRead);
                        }
                    }

                    lbContent.Invoke(new Action(() =>
                    {
                        lbContent.Items.Add("Image received and saved: " + receivedFileName + Environment.NewLine);
                    }));

                    client.Close(); // Close the client connection
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur during client connection and data transfer
                    lbContent.Invoke(new Action(() =>
                    {
                        lbContent.Items.Add("Error: " + ex.Message + Environment.NewLine);
                    }));
                }
            }
        }
    }
}
