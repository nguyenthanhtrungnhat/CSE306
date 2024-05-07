namespace Assignment_2
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
            this.utf8 = new System.Windows.Forms.RadioButton();
            this.unicode = new System.Windows.Forms.RadioButton();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // utf8
            // 
            this.utf8.AutoSize = true;
            this.utf8.Checked = true;
            this.utf8.Location = new System.Drawing.Point(43, 37);
            this.utf8.Name = "utf8";
            this.utf8.Size = new System.Drawing.Size(52, 17);
            this.utf8.TabIndex = 0;
            this.utf8.TabStop = true;
            this.utf8.Text = "UTF8";
            this.utf8.UseVisualStyleBackColor = true;
            // 
            // unicode
            // 
            this.unicode.AutoSize = true;
            this.unicode.Location = new System.Drawing.Point(43, 61);
            this.unicode.Name = "unicode";
            this.unicode.Size = new System.Drawing.Size(65, 17);
            this.unicode.TabIndex = 1;
            this.unicode.Text = "Unicode";
            this.unicode.UseVisualStyleBackColor = true;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(43, 110);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(332, 20);
            this.txtPath.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(381, 110);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(43, 136);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(122, 23);
            this.btnRead.TabIndex = 4;
            this.btnRead.Text = "Read from a file";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(43, 333);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save Content to a file";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(43, 198);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContent.Size = new System.Drawing.Size(413, 129);
            this.txtContent.TabIndex = 6;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selecting an coding";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Content";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "File Path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 399);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.unicode);
            this.Controls.Add(this.utf8);
            this.Name = "Form1";
            this.Text = "File Stream and Encoding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton utf8;
        private System.Windows.Forms.RadioButton unicode;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

