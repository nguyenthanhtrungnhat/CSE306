using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using static Assignment_3.Form1;

namespace Assignment_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void ClearAllFields()
        {
            txtId.Clear();
            txtName.Clear();
            txtAddress.Clear();
            pictureBox1.Image = null;
            openFileDialog1.FileName = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSelCha_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPG(*jpg)|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.WriteLine(txtId.Text);
                    sw.WriteLine(txtName.Text);
                    sw.WriteLine(txtAddress.Text);
                    sw.WriteLine(openFileDialog1.FileName);
                }
            }
        }


        private void btnRead_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                    {
                        txtId.Text = sr.ReadLine();
                        txtName.Text = sr.ReadLine();
                        txtAddress.Text = sr.ReadLine();
                        openFileDialog1.FileName = sr.ReadLine();
                        pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file: " + ex.Message);
                }
            }
        }


        // Serialization
        private void btnSerialize_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JSON files (.json)|.json|All files(.)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int id = Int32.Parse(txtId.Text);
                string name = txtName.Text;
                DateTime dateOfBirth = this.txtDateofBirth.Value;
                string address = txtAddress.Text;
                string avatarPath = openFileDialog1.FileName;

                // Create a new student object
                Student student = new Student(id, name, dateOfBirth, address, avatarPath);

                // Serialize the student object to JSON
                string jsonString = JsonSerializer.Serialize(student);

                // Write the JSON string to a file
                File.WriteAllText(saveFileDialog1.FileName, jsonString);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // Deserialization
        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JSON files (.json)|.json|All files(.)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Read the JSON string from the file
                string jsonString = File.ReadAllText(openFileDialog1.FileName);

                try
                {
                    // Deserialize the JSON string into a Student object
                    Student student = JsonSerializer.Deserialize<Student>(jsonString);

                    // Update the controls on the interface with the data from the Student object
                    txtId.Text = student.Id.ToString();
                    txtName.Text = student.Name;
                    txtDateofBirth.Value = student.Dob;
                    txtAddress.Text = student.Address;
                    openFileDialog1.FileName = student.Avatar;
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
                catch (JsonException ex)
                {
                    // Handle any errors that occur during deserialization
                    MessageBox.Show("Error deserializing JSON: " + ex.Message);
                }
            }
        }

        public class Student
        {
            int id;
            string name;
            DateTime dob;
            string address;
            String avatar;

            public Student(int id, string name, DateTime dob, string address, string avatar)
            {
                this.id = id;
                this.name = name;
                this.dob = dob;
                this.address = address;
                this.avatar = avatar;
            }
            // Getter and Setter for id
            public int Id
            {
                get { return id; }
                set { id = value; }
            }

            // Getter and Setter for name
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            // Getter and Setter for dob
            public DateTime Dob
            {
                get { return dob; }
                set { dob = value; }
            }

            // Getter and Setter for address
            public string Address
            {
                get { return address; }
                set { address = value; }
            }

            // Getter and Setter for avatar
            public string Avatar
            {
                get { return avatar; }
                set { avatar = value; }
            }


        }
    }
}