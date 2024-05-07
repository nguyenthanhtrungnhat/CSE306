using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_CLIENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TcpClient client;
        private void btnListen_Click(object sender, EventArgs e)
        {
            client = new TcpClient(txtIp.Text, Int32.Parse(txtPort.Text));
            lbContent.Items.Add("Connected to the server!" + Environment.NewLine);
            Thread t = new Thread(Listen);
            t.Start();
        }
        void Listen()
        {
            NetworkStream ns = client.GetStream();
            Byte[] bytes = new Byte[256];
            while (true)
            {

                lbContent.Invoke(new Action(() =>
                {
                    lbContent.Items.Add("Connected!" + Environment.NewLine);
                }));

                int thisRead = 0;
                string recieveData;
                while ((thisRead = ns.Read(bytes, 0, bytes.Length)) != 0)
                {
                    recieveData = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
                    lbContent.Invoke(new Action(() =>
                    {
                        lbContent.Items.Add("Server: " + recieveData + Environment.NewLine);

                    }));
                    Array.Clear(bytes, 0, bytes.Length);
                }
                client.Close();
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            NetworkStream ns = client.GetStream();
            string text = txtText.Text;
            ns.Write(Encoding.UTF8.GetBytes(text), 0, Encoding.UTF8.GetBytes(text).Length);
            txtText.Clear();
        }
    }
}
