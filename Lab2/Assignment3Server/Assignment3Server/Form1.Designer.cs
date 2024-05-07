namespace Assignment3Server
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
            this.lbContent = new System.Windows.Forms.ListBox();
            this.btnListen = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lbContent
            // 
            this.lbContent.FormattingEnabled = true;
            this.lbContent.Location = new System.Drawing.Point(41, 44);
            this.lbContent.Name = "lbContent";
            this.lbContent.ScrollAlwaysVisible = true;
            this.lbContent.Size = new System.Drawing.Size(339, 186);
            this.lbContent.TabIndex = 0;
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(415, 113);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(75, 23);
            this.btnListen.TabIndex = 1;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 264);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.lbContent);
            this.Name = "Form1";
            this.Text = "Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbContent;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

