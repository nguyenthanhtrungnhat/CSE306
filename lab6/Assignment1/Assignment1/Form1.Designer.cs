namespace Assignment1
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
            btnHash = new Button();
            lbHash = new ListBox();
            txtPass = new TextBox();
            txtKey = new TextBox();
            btnSearch = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnHash
            // 
            btnHash.Location = new Point(489, 70);
            btnHash.Name = "btnHash";
            btnHash.Size = new Size(75, 23);
            btnHash.TabIndex = 0;
            btnHash.Text = "Hash";
            btnHash.UseVisualStyleBackColor = true;
            btnHash.Click += btnHash_Click;
            // 
            // lbHash
            // 
            lbHash.FormattingEnabled = true;
            lbHash.ItemHeight = 15;
            lbHash.Location = new Point(85, 217);
            lbHash.Name = "lbHash";
            lbHash.Size = new Size(479, 154);
            lbHash.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(85, 70);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(353, 23);
            txtPass.TabIndex = 3;
            // 
            // txtKey
            // 
            txtKey.Location = new Point(85, 144);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(353, 23);
            txtKey.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(489, 143);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 199);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 6;
            label1.Text = "HashList";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 52);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 7;
            label2.Text = "Your Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 126);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 8;
            label3.Text = "Your Keyword";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 431);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(txtKey);
            Controls.Add(txtPass);
            Controls.Add(lbHash);
            Controls.Add(btnHash);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHash;
        private ListBox lbHash;
        private TextBox txtPass;
        private TextBox txtKey;
        private Button btnSearch;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
