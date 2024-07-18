namespace Assignment2
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
            btnSelFile = new Button();
            btnCompress = new Button();
            lbList = new ListBox();
            txtPath = new TextBox();
            txtPrefix = new TextBox();
            openFileDialog = new OpenFileDialog();
            comboboxRatio = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            folderBrowserDialog = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // btnSelFile
            // 
            btnSelFile.Location = new Point(354, 34);
            btnSelFile.Name = "btnSelFile";
            btnSelFile.Size = new Size(88, 23);
            btnSelFile.TabIndex = 1;
            btnSelFile.Text = "Select File";
            btnSelFile.UseVisualStyleBackColor = true;
            btnSelFile.Click += btnSelFile_Click;
            // 
            // btnCompress
            // 
            btnCompress.Location = new Point(367, 271);
            btnCompress.Name = "btnCompress";
            btnCompress.Size = new Size(75, 23);
            btnCompress.TabIndex = 2;
            btnCompress.Text = "Compress";
            btnCompress.UseVisualStyleBackColor = true;
            btnCompress.Click += btnCompress_Click;
            // 
            // lbList
            // 
            lbList.FormattingEnabled = true;
            lbList.ItemHeight = 15;
            lbList.Location = new Point(52, 107);
            lbList.Name = "lbList";
            lbList.Size = new Size(390, 109);
            lbList.TabIndex = 3;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(52, 34);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(284, 23);
            txtPath.TabIndex = 4;
            // 
            // txtPrefix
            // 
            txtPrefix.Location = new Point(196, 271);
            txtPrefix.Name = "txtPrefix";
            txtPrefix.Size = new Size(100, 23);
            txtPrefix.TabIndex = 5;
            txtPrefix.Text = "compressed";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // comboboxRatio
            // 
            comboboxRatio.FormattingEnabled = true;
            comboboxRatio.Location = new Point(52, 271);
            comboboxRatio.Name = "comboboxRatio";
            comboboxRatio.Size = new Size(50, 23);
            comboboxRatio.TabIndex = 6;
            comboboxRatio.Text = "60";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 16);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 7;
            label1.Text = "Select Images";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 89);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 8;
            label2.Text = "Image List";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 253);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 9;
            label3.Text = "Prefix";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 253);
            label4.Name = "label4";
            label4.Size = new Size(125, 15);
            label4.TabIndex = 10;
            label4.Text = "Compression Ratio(%)";
            // 
            // button1
            // 
            button1.Location = new Point(354, 63);
            button1.Name = "button1";
            button1.Size = new Size(88, 23);
            button1.TabIndex = 11;
            button1.Text = "Select Folder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 323);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboboxRatio);
            Controls.Add(txtPrefix);
            Controls.Add(txtPath);
            Controls.Add(lbList);
            Controls.Add(btnCompress);
            Controls.Add(btnSelFile);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSelFile;
        private Button btnCompress;
        private ListBox lbList;
        private TextBox txtPath;
        private TextBox txtPrefix;
        private OpenFileDialog openFileDialog;
        private ComboBox comboboxRatio;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private FolderBrowserDialog folderBrowserDialog;
    }
}
