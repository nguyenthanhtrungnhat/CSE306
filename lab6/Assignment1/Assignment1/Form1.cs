using System.Security.Cryptography;
using System.Text;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> list = new List<string>();
        private static string GetHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] data = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                var strBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    strBuilder.Append(data[i].ToString());

                }
                return strBuilder.ToString().ToUpper();
            }
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            string hashResult = GetHash(txtPass.Text);
            list.Add(hashResult);
            lbHash.Items.Clear();
            lbHash.Items.AddRange(list.ToArray());

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchHash =GetHash( txtKey.Text);
            lbHash.Items.Clear();
            if (list.Contains(searchHash))
            {
                lbHash.Items.Add(searchHash);
            }
            else
            {
                MessageBox.Show("Hash not found in the list.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
