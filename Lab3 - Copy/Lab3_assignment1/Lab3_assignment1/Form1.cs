using System.Net;

namespace Lab3_assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            IPAddress[]addresses = Dns.GetHostAddresses(txtAddress.Text);
            foreach(IPAddress ip in addresses)
            {
            txtContent.AppendText(ip.ToString()+Environment.NewLine);
            }
        }
    }
}
