using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                    return codec;
            }
            return null;
        }

        private void btnSelFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lbList.Items.Clear();
                string filePath = openFileDialog.FileName;
                lbList.Items.Add(filePath);
            }
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            Int64 ratio = Int64.Parse(comboboxRatio.Text);
            foreach (string filePath in lbList.Items)
            {
                using (Bitmap bm = new Bitmap(filePath))
                {
                    String fullPath = Path.GetDirectoryName(filePath);
                    String currentName = Path.GetFileName(filePath);
                    currentName = txtPrefix.Text + currentName;
                    String newPath = Path.Combine(fullPath, currentName);
                    ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);
                    System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
                    EncoderParameters myEncoderParameters = new EncoderParameters(1);
                    EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, ratio);
                    myEncoderParameters.Param[0] = myEncoderParameter;
                    bm.Save(newPath, jpgEncoder, myEncoderParameters);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = folderBrowserDialog.SelectedPath;
            }
        }


    }
}
