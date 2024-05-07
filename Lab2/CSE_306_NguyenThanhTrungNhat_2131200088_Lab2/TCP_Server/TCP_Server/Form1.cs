using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TCP_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TcpListener server;
        TcpClient client;

        private void btnListen_Click(object sender, EventArgs e)
        {
            server = new TcpListener(IPAddress.Parse(txtIp.Text), Int32.Parse(txtPort.Text));
            server.Start();
            lbContent.Items.Add("Waiting for connection");
            Thread t = new Thread(Listen);
            t.Start();
        }
        void Listen()
        {
            Byte[] bytes = new Byte[256];
            while (true)
            {
                client = server.AcceptTcpClient();
                lbContent.Invoke(new Action(() =>
                {
                    lbContent.Items.Add("Connected!" + Environment.NewLine);
                }));
                NetworkStream ns = client.GetStream();
                int thisRead = 0;
                string recieveData;
                while ((thisRead = ns.Read(bytes, 0, bytes.Length)) != 0)
                {
                    recieveData = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
                    lbContent.Invoke(new Action(() =>
                    {
                        lbContent.Items.Add("Client: " + recieveData + Environment.NewLine);

                    }));
                    Array.Clear(bytes, 0, bytes.Length);
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            NetworkStream ns=client.GetStream();
            string text=txtText.Text;
            ns.Write(Encoding.UTF8.GetBytes(text),0,Encoding.UTF8.GetBytes(text).Length);
            txtText.Clear();
        }
    }
}
