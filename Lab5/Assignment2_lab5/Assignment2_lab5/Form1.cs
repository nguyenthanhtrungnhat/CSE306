using System.Security.Cryptography;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment2_lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        RSAParameters RSAPublic;
        RSAParameters RSAPrvate;
        byte[] encryptedtext;
        private void Form1_Load(object sender, EventArgs e)
        {
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSAPrvate = RSA.ExportParameters(true);
                RSAPublic = RSA.ExportParameters(false);
            }

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] dataToEncrypt = Encoding.Unicode.GetBytes(txtToEncrypt.Text);
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAPublic);
                    encryptedtext = RSA.Encrypt(dataToEncrypt, false);
                    txtEncrypted.Text = Encoding.Unicode.GetString(encryptedtext);

                }

            }
            catch (ArgumentException)
            {
                MessageBox.Show("Encryption failed!");
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            byte[] decryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.ImportParameters(RSAPrvate);
                decryptedData = RSA.Decrypt(encryptedtext, false); 
                txtDecrypt.Text= Encoding.Unicode.GetString(decryptedData);
            }
        }
    }
}
