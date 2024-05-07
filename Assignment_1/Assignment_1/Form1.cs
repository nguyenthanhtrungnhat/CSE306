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

namespace Assignment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "txt file | *.txt|All files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = openFileDialog.FileName;
            };
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(txtPath.Text))
            {
                txtContent.Text = sr.ReadToEnd();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "txt file | *.txt|All files|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(new FileStream(saveFileDialog.FileName,
                    FileMode.Create, FileAccess.ReadWrite)))
                {
                    sw.Write(txtContent.Text);
                }
                txtContent.Clear();
                MessageBox.Show("Saved!", "Notification");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
