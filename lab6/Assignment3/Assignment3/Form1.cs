using System.IO.Compression;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSeFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "zip";
            saveFileDialog1.AddExtension = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ZipFile.CreateFromDirectory(txtPath.Text, saveFileDialog1.FileName);
                MessageBox.Show("Done");
            }
        }


        private void btnEx_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                ZipFile.ExtractToDirectory(txtPath.Text, folderBrowserDialog1.SelectedPath);

            }


        }

        private void btnSeFile_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = openFileDialog1.FileName;
            }
        }
    }
}
