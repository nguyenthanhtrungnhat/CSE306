using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            using (FileStream fs = File.OpenRead(txtPath.Text))
            {
                byte[] a = new byte[1024];
                int readLen;
                while ((readLen = fs.Read(a, 0, a.Length)) > 0)
                {
                    if (utf8.Checked)
                    {
                        UTF8Encoding utf8Encoding = new UTF8Encoding(true);
                        txtContent.Text = utf8Encoding.GetString(a, 0, readLen);
                        //Ma hoa string thanh utf8
                    }
                    else
                    {
                        UnicodeEncoding encode = new UnicodeEncoding(); txtContent.Text = encode.GetString(a, 0, readLen);
                        //Ma hoa string thanh utf16
                    }
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "txt file | *.txt|All files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = openFileDialog.FileName;
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "txt file | *.txt|All files|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.Open(saveFileDialog.FileName,
                   FileMode.Create, FileAccess.ReadWrite))
                {
                    if (utf8.Checked)
                    {

                        byte[] content = new UTF8Encoding(true).GetBytes(txtContent.Text);
                        fs.Write(content, 0, content.Length);
                    }
                    else
                    {
                        byte[] content = new UnicodeEncoding().GetBytes(txtContent.Text);
                        fs.Write(content, 0, content.Length);
                    }
                }
            }
            txtContent.Clear();
            MessageBox.Show("Saved!", "Notification");
        }
    }
}

