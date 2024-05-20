namespace Lab4Assignment2
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
            txtServer = new TextBox();
            txtUserName = new TextBox();
            txtPassWord = new TextBox();
            txtPort = new TextBox();
            txtPath1 = new TextBox();
            txtFolderLocal = new TextBox();
            txtFile = new TextBox();
            btnLogin = new Button();
            btnUpload = new Button();
            btDownload = new Button();
            btnDelete = new Button();
            btnRename = new Button();
            btnBack = new Button();
            txtStatus = new TextBox();
            txtPath = new TextBox();
            txtFolders1 = new TextBox();
            txtFiles1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtTreeView = new TreeView();
            SuspendLayout();
            // 
            // txtServer
            // 
            txtServer.Location = new Point(81, 26);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(304, 23);
            txtServer.TabIndex = 0;
            txtServer.Text = "ftp://127.0.0.1";
            txtServer.UseWaitCursor = true;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(81, 67);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(100, 23);
            txtUserName.TabIndex = 1;
            txtUserName.Text = "anonymous";
            txtUserName.UseWaitCursor = true;
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(81, 106);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(100, 23);
            txtPassWord.TabIndex = 2;
            txtPassWord.UseWaitCursor = true;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(285, 67);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(100, 23);
            txtPort.TabIndex = 3;
            txtPort.Text = "21";
            txtPort.UseWaitCursor = true;
            // 
            // txtPath1
            // 
            txtPath1.Location = new Point(81, 176);
            txtPath1.Name = "txtPath1";
            txtPath1.Size = new Size(304, 23);
            txtPath1.TabIndex = 4;
            txtPath1.UseWaitCursor = true;
            // 
            // txtFolderLocal
            // 
            txtFolderLocal.Location = new Point(237, 237);
            txtFolderLocal.Multiline = true;
            txtFolderLocal.Name = "txtFolderLocal";
            txtFolderLocal.Size = new Size(136, 67);
            txtFolderLocal.TabIndex = 5;
            txtFolderLocal.UseWaitCursor = true;
            // 
            // txtFile
            // 
            txtFile.Location = new Point(237, 331);
            txtFile.Multiline = true;
            txtFile.Name = "txtFile";
            txtFile.Size = new Size(136, 78);
            txtFile.TabIndex = 7;
            txtFile.UseWaitCursor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(417, 82);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 42);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.UseWaitCursor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(417, 236);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(75, 23);
            btnUpload.TabIndex = 9;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.UseWaitCursor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // btDownload
            // 
            btDownload.Location = new Point(417, 281);
            btDownload.Name = "btDownload";
            btDownload.Size = new Size(75, 23);
            btDownload.TabIndex = 10;
            btDownload.Text = "Download";
            btDownload.UseVisualStyleBackColor = true;
            btDownload.UseWaitCursor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(417, 330);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.UseWaitCursor = true;
            // 
            // btnRename
            // 
            btnRename.Location = new Point(417, 375);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(75, 23);
            btnRename.TabIndex = 12;
            btnRename.Text = "Rename";
            btnRename.UseVisualStyleBackColor = true;
            btnRename.UseWaitCursor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(600, 281);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.UseWaitCursor = true;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(498, 26);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(284, 67);
            txtStatus.TabIndex = 14;
            txtStatus.UseWaitCursor = true;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(535, 137);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(247, 23);
            txtPath.TabIndex = 15;
            txtPath.UseWaitCursor = true;
            // 
            // txtFolders1
            // 
            txtFolders1.Location = new Point(498, 198);
            txtFolders1.Multiline = true;
            txtFolders1.Name = "txtFolders1";
            txtFolders1.Size = new Size(284, 67);
            txtFolders1.TabIndex = 16;
            txtFolders1.UseWaitCursor = true;
            // 
            // txtFiles1
            // 
            txtFiles1.Location = new Point(498, 330);
            txtFiles1.Multiline = true;
            txtFiles1.Name = "txtFiles1";
            txtFiles1.Size = new Size(284, 79);
            txtFiles1.TabIndex = 17;
            txtFiles1.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 18;
            label1.Text = "Server";
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 19;
            label2.Text = "User name";
            label2.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 109);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 20;
            label3.Text = "Password";
            label3.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 71);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 21;
            label4.Text = "Port";
            label4.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(498, 8);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 22;
            label5.Text = "Status";
            label5.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(498, 140);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 23;
            label6.Text = "Path";
            label6.UseWaitCursor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 179);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 24;
            label7.Text = "Path";
            label7.UseWaitCursor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 219);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 25;
            label8.Text = "Tree view";
            label8.UseWaitCursor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(237, 219);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 27;
            label9.Text = "Folder";
            label9.UseWaitCursor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(237, 313);
            label10.Name = "label10";
            label10.Size = new Size(25, 15);
            label10.TabIndex = 28;
            label10.Text = "File";
            label10.UseWaitCursor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(499, 312);
            label11.Name = "label11";
            label11.Size = new Size(30, 15);
            label11.TabIndex = 29;
            label11.Text = "Files";
            label11.UseWaitCursor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(498, 180);
            label12.Name = "label12";
            label12.Size = new Size(45, 15);
            label12.TabIndex = 30;
            label12.Text = "Folders";
            label12.UseWaitCursor = true;
            // 
            // txtTreeView
            // 
            txtTreeView.Location = new Point(13, 237);
            txtTreeView.Name = "txtTreeView";
            txtTreeView.Size = new Size(207, 172);
            txtTreeView.TabIndex = 31;
            txtTreeView.UseWaitCursor = true;
            txtTreeView.BeforeExpand += treeView_BeforeExpand;
            txtTreeView.NodeMouseClick += TreeView_NodeMouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 421);
            Controls.Add(txtTreeView);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFiles1);
            Controls.Add(txtFolders1);
            Controls.Add(txtPath);
            Controls.Add(txtStatus);
            Controls.Add(btnBack);
            Controls.Add(btnRename);
            Controls.Add(btnDelete);
            Controls.Add(btDownload);
            Controls.Add(btnUpload);
            Controls.Add(btnLogin);
            Controls.Add(txtFile);
            Controls.Add(txtFolderLocal);
            Controls.Add(txtPath1);
            Controls.Add(txtPort);
            Controls.Add(txtPassWord);
            Controls.Add(txtUserName);
            Controls.Add(txtServer);
            Name = "Form1";
            Text = "Form1";
            UseWaitCursor = true;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtServer;
        private TextBox txtUserName;
        private TextBox txtPassWord;
        private TextBox txtPort;
        private TextBox txtPath1;
        private TextBox txtFolderLocal;
        private TextBox txtFile;
        private Button btnLogin;
        private Button btnUpload;
        private Button btDownload;
        private Button btnDelete;
        private Button btnRename;
        private Button btnBack;
        private TextBox txtStatus;
        private TextBox txtPath;
        private TextBox txtFolders1;
        private TextBox txtFiles1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TreeView txtTreeView;
    }
}
