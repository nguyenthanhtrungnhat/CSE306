using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnDown_Click(object sender, EventArgs e)
        {
          if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                using (HttpClient client = new HttpClient())
                { 
                    //tai nguyen truc tiep phai la uri
                    Uri uri =new Uri(txtUrl.Text);
                    string fileName=Path.GetFileName(uri.AbsolutePath);
                    using (var response = await client.GetAsync(uri))
                    {
                        //check xem file co dc cho phep tai khong
                        response.EnsureSuccessStatusCode();

                        var filePath=Path.Combine(folderBrowserDialog.SelectedPath, fileName);

                        using (var imageStream = await response.Content.ReadAsStreamAsync())
                        {
                            // Save the stream to a file
                            using (var fileStream = File.Create(filePath))
                            {
                                await imageStream.CopyToAsync(fileStream);
                                MessageBox.Show("Done!");
                            }
                           
                        }
                    }

                }
            }

        }
    }
}
