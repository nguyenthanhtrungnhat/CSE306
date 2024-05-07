namespace Lab3_assignment1
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
            btnResolve = new Button();
            txtAddress = new TextBox();
            txtContent = new TextBox();
            SuspendLayout();
            // 
            // btnResolve
            // 
            btnResolve.Location = new Point(509, 52);
            btnResolve.Name = "btnResolve";
            btnResolve.Size = new Size(75, 23);
            btnResolve.TabIndex = 0;
            btnResolve.Text = "Resolve";
            btnResolve.UseVisualStyleBackColor = true;
            btnResolve.Click += btnResolve_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(66, 52);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(383, 23);
            txtAddress.TabIndex = 1;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(66, 113);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.ScrollBars = ScrollBars.Both;
            txtContent.Size = new Size(518, 171);
            txtContent.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 350);
            Controls.Add(txtContent);
            Controls.Add(txtAddress);
            Controls.Add(btnResolve);
            Name = "Form1";
            Text = "Assignment1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnResolve;
        private TextBox txtAddress;
        private TextBox txtContent;
    }
}
