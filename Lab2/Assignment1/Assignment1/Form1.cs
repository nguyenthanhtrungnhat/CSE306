using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Create a array of threads
        Thread[] threadArr;
        int numFiles = 0;


        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "jpg file | *.jpg|txt file|*.txt|png file|*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] filePaths = openFileDialog.FileNames;
                numFiles = filePaths.Length;
                threadArr=new Thread[numFiles];
                for (int i = 0; i < numFiles; i++)
                {
                    txtList.AppendText(filePaths[i] + Environment.NewLine);
                    threadArr[i]= new Thread(UploadFile);
                    threadArr[i].Start(filePaths[i]);
                }
                Thread t= new Thread(joinThread);
                t.Start();
            }
        }
        //avoiding crashing or lag
        void joinThread()
        {
            for (int i = 0; i < numFiles; i++)
            {
                threadArr[i].Join();
            }
        }


        void UploadFile(object _filePath)
        {
            string filePath = (string)_filePath;
            //Remove all the extra info of files, just keep the name and extention of the file
            string fileName = Path.GetFileName(filePath);
            //Write on another thread that show the name
            Action _uploading = delegate
            {
                lbStatus.Items.Add("Uploading: " + fileName);
            };
            lbStatus.Invoke(_uploading);

            //Gia lap thoi gian cho
            Random r = new Random();
            int randomNumber = r.Next(2, 6);
            Thread.Sleep(randomNumber);
            copyFileToFolder(filePath);
            MessageBox.Show("Successful!"," ",MessageBoxButtons.OK);
        }
        void copyFileToFolder(string filePath)
        {
            string destinationDIrectory = "./Images/";
            var destination = new DirectoryInfo(destinationDIrectory);
            if (!destination.Exists)
            {
                destination.Create();
            }
            File.Copy(filePath, destinationDIrectory + Path.GetFileName(filePath));

        }


        private void lbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
