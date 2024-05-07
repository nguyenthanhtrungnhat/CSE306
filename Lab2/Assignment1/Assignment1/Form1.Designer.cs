namespace Assignment1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.ListBox();
            this.txtList = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status";
            // 
            // lbStatus
            // 
            this.lbStatus.FormattingEnabled = true;
            this.lbStatus.Location = new System.Drawing.Point(45, 150);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.ScrollAlwaysVisible = true;
            this.lbStatus.Size = new System.Drawing.Size(383, 147);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.SelectedIndexChanged += new System.EventHandler(this.lbStatus_SelectedIndexChanged);
            // 
            // txtList
            // 
            this.txtList.Location = new System.Drawing.Point(45, 42);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtList.Size = new System.Drawing.Size(302, 59);
            this.txtList.TabIndex = 3;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(353, 60);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 29);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Multiselect = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 338);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Assignment_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbStatus;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

