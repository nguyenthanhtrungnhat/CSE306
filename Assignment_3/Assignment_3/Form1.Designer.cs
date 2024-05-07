namespace Assignment_3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelCha = new System.Windows.Forms.Button();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSerialize = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtDateofBirth = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelCha
            // 
            this.btnSelCha.Location = new System.Drawing.Point(348, 55);
            this.btnSelCha.Name = "btnSelCha";
            this.btnSelCha.Size = new System.Drawing.Size(111, 23);
            this.btnSelCha.TabIndex = 0;
            this.btnSelCha.Text = "Select/Change";
            this.btnSelCha.UseVisualStyleBackColor = true;
            this.btnSelCha.Click += new System.EventHandler(this.btnSelCha_Click);
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.Location = new System.Drawing.Point(295, 299);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(194, 23);
            this.btnDeserialize.TabIndex = 1;
            this.btnDeserialize.Text = "Read from a file and Deserialize";
            this.btnDeserialize.UseVisualStyleBackColor = true;
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(54, 299);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(194, 23);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Read from a file";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(54, 348);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(194, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save to a file";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSerialize
            // 
            this.btnSerialize.Location = new System.Drawing.Point(295, 348);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(194, 23);
            this.btnSerialize.TabIndex = 4;
            this.btnSerialize.Text = "Serialize and Save to a file";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(54, 58);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(194, 20);
            this.txtId.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(54, 119);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(194, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(57, 232);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(191, 45);
            this.txtAddress.TabIndex = 8;
            // 
            // txtDateofBirth
            // 
            this.txtDateofBirth.Location = new System.Drawing.Point(54, 171);
            this.txtDateofBirth.Name = "txtDateofBirth";
            this.txtDateofBirth.Size = new System.Drawing.Size(194, 20);
            this.txtDateofBirth.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Full Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Student ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Avatar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(348, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 109);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 420);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDateofBirth);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnSerialize);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnDeserialize);
            this.Controls.Add(this.btnSelCha);
            this.Name = "Form1";
            this.Text = "Student Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelCha;
        private System.Windows.Forms.Button btnDeserialize;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker txtDateofBirth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

