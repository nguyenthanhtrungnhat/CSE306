using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Assigment3Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TcpClient client;

        private void btnSend_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                txtContent.Text = filePath;
                Thread thread = new Thread(() => UploadFile(filePath));
                thread.Start();
            }
        }

        void UploadFile(string filePath)
        {         
                client = new TcpClient("127.0.0.1", 20000);

                NetworkStream ns = client.GetStream();

                using (FileStream fs = File.OpenRead(filePath))
                {
                    byte[] sentData = new byte[1024];
                    int bytesRead;
                    while ((bytesRead = fs.Read(sentData, 0, sentData.Length)) > 0)
                    {
                        ns.Write(sentData, 0, bytesRead);
                    }
                }
                client.Close();         
        }
    }
}
