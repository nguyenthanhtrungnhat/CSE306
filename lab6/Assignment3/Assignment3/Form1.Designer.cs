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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnCompress = new Button();
            btnSeFolder = new Button();
            txtPath = new TextBox();
            tabPage2 = new TabPage();
            btnEx = new Button();
            btnSeFile = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(74, 55);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(495, 249);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnCompress);
            tabPage1.Controls.Add(btnSeFolder);
            tabPage1.Controls.Add(txtPath);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(487, 221);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Compression";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCompress
            // 
            btnCompress.Location = new Point(189, 158);
            btnCompress.Name = "btnCompress";
            btnCompress.Size = new Size(75, 23);
            btnCompress.TabIndex = 1;
            btnCompress.Text = "Compress";
            btnCompress.UseVisualStyleBackColor = true;
            btnCompress.Click += btnCompress_Click;
            // 
            // btnSeFolder
            // 
            btnSeFolder.Location = new Point(370, 80);
            btnSeFolder.Name = "btnSeFolder";
            btnSeFolder.Size = new Size(98, 23);
            btnSeFolder.TabIndex = 2;
            btnSeFolder.Text = "Select Folder";
            btnSeFolder.UseVisualStyleBackColor = true;
            btnSeFolder.Click += btnSeFolder_Click;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(32, 81);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(312, 23);
            txtPath.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnEx);
            tabPage2.Controls.Add(btnSeFile);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(487, 221);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Extract";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEx
            // 
            btnEx.Location = new Point(194, 146);
            btnEx.Name = "btnEx";
            btnEx.Size = new Size(98, 23);
            btnEx.TabIndex = 6;
            btnEx.Text = "Extract";
            btnEx.UseVisualStyleBackColor = true;
            btnEx.Click += btnEx_Click;
            // 
            // btnSeFile
            // 
            btnSeFile.Location = new Point(194, 99);
            btnSeFile.Name = "btnSeFile";
            btnSeFile.Size = new Size(98, 23);
            btnSeFile.TabIndex = 5;
            btnSeFile.Text = "Select File";
            btnSeFile.UseVisualStyleBackColor = true;
            btnSeFile.Click += btnSeFile_Click_1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 367);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnCompress;
        private Button btnSeFolder;
        private TextBox txtPath;
        private FolderBrowserDialog folderBrowserDialog1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Button btnEx;
        private Button btnSeFile;
    }
}
