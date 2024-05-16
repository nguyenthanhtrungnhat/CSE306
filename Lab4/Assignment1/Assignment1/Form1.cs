using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChose_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt file (*txt)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtMailTo.Text = openFileDialog1.FileName;
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt file (*txt)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var basicCredential = new NetworkCredential(txtUserName.Text, txtPass.Text);
            SmtpClient client = new SmtpClient(txtGmail.Text, Int32.Parse(txtPort.Text));
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = basicCredential;


            MailAddress from = new MailAddress(txtMailFrom.Text);

            string[] emailAddresses = File.ReadAllLines(txtMailTo.Text);

            foreach (string email in emailAddresses)
            {
                if (!string.IsNullOrWhiteSpace(email))
                {
                    MailAddress to = new MailAddress(email);
                    MailMessage message = new MailMessage(from, to);
                    message.Body = txtMess.Text;
                    message.BodyEncoding = System.Text.Encoding.UTF8;
                    message.Subject = txtTitle.Text;
                    message.SubjectEncoding = System.Text.Encoding.UTF8;
                    if (!string.IsNullOrEmpty(txtFilePath.Text))
                    {
                        Attachment attachment = new Attachment(txtFilePath.Text);
                        message.Attachments.Add(attachment);
                    }
                    client.Send(message);
                }
            }


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
