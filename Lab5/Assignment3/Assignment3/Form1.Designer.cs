namespace Assignment3
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
            btnEncr = new Button();
            btnDecr = new Button();
            txtPlain = new TextBox();
            txtEncrypted = new TextBox();
            txtDecrypted = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnEncr
            // 
            btnEncr.Location = new Point(525, 81);
            btnEncr.Name = "btnEncr";
            btnEncr.Size = new Size(75, 23);
            btnEncr.TabIndex = 0;
            btnEncr.Text = "Encrypt";
            btnEncr.UseVisualStyleBackColor = true;
            btnEncr.Click += btnEncr_Click;
            // 
            // btnDecr
            // 
            btnDecr.Location = new Point(525, 186);
            btnDecr.Name = "btnDecr";
            btnDecr.Size = new Size(75, 23);
            btnDecr.TabIndex = 1;
            btnDecr.Text = "Decrypt";
            btnDecr.UseVisualStyleBackColor = true;
            btnDecr.Click += btnDecr_Click;
            // 
            // txtPlain
            // 
            txtPlain.Location = new Point(91, 51);
            txtPlain.Multiline = true;
            txtPlain.Name = "txtPlain";
            txtPlain.Size = new Size(428, 82);
            txtPlain.TabIndex = 2;
            // 
            // txtEncrypted
            // 
            txtEncrypted.Location = new Point(91, 159);
            txtEncrypted.Multiline = true;
            txtEncrypted.Name = "txtEncrypted";
            txtEncrypted.Size = new Size(428, 82);
            txtEncrypted.TabIndex = 3;
            // 
            // txtDecrypted
            // 
            txtDecrypted.Location = new Point(91, 270);
            txtDecrypted.Multiline = true;
            txtDecrypted.Name = "txtDecrypted";
            txtDecrypted.Size = new Size(428, 82);
            txtDecrypted.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 5;
            label1.Text = "Plain Text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 270);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 6;
            label2.Text = "Plain Text";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 159);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 7;
            label3.Text = "Cipher Text";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 374);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDecrypted);
            Controls.Add(txtEncrypted);
            Controls.Add(txtPlain);
            Controls.Add(btnDecr);
            Controls.Add(btnEncr);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEncr;
        private Button btnDecr;
        private TextBox txtPlain;
        private TextBox txtEncrypted;
        private TextBox txtDecrypted;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
