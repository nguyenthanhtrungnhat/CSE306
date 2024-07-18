namespace Assignment2_lab5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtToEncrypt = new TextBox();
            txtEncrypted = new TextBox();
            txtDecrypt = new TextBox();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtToEncrypt
            // 
            txtToEncrypt.Location = new Point(99, 59);
            txtToEncrypt.Multiline = true;
            txtToEncrypt.Name = "txtToEncrypt";
            txtToEncrypt.Size = new Size(418, 58);
            txtToEncrypt.TabIndex = 0;
            // 
            // txtEncrypted
            // 
            txtEncrypted.Location = new Point(99, 139);
            txtEncrypted.Multiline = true;
            txtEncrypted.Name = "txtEncrypted";
            txtEncrypted.Size = new Size(418, 58);
            txtEncrypted.TabIndex = 1;
            // 
            // txtDecrypt
            // 
            txtDecrypt.Location = new Point(99, 220);
            txtDecrypt.Multiline = true;
            txtDecrypt.Name = "txtDecrypt";
            txtDecrypt.Size = new Size(418, 58);
            txtDecrypt.TabIndex = 2;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(535, 75);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(75, 23);
            btnEncrypt.TabIndex = 3;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(535, 158);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(75, 23);
            btnDecrypt.TabIndex = 4;
            btnDecrypt.Text = "Decypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 62);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 5;
            label1.Text = "Plain Text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 142);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 6;
            label2.Text = "Cipher Text";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 223);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 7;
            label3.Text = "Plain Text";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 337);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(txtDecrypt);
            Controls.Add(txtEncrypted);
            Controls.Add(txtToEncrypt);
            Name = "Form1";
            Text = "RSA algorithm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtToEncrypt;
        private TextBox txtEncrypted;
        private TextBox txtDecrypt;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
