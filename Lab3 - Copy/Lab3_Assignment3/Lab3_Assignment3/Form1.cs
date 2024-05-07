using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            HttpClient client = new HttpClient();
            var values = new Dictionary<string, string>
        {
            { txtPara.Text, txtValue.Text }
        };

            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync(txtUrl.Text, content);

            var responseString = await response.Content.ReadAsStringAsync();

           txtResult.Text = responseString;
        }
    }
}
