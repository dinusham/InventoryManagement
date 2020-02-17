namespace MainInventoryForms
{
    partial class frmLogin
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
            this.loginUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.loginCancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name :";
            // 
            // loginUserName
            // 
            this.loginUserName.Location = new System.Drawing.Point(177, 70);
            this.loginUserName.Margin = new System.Windows.Forms.Padding(4);
            this.loginUserName.Name = "loginUserName";
            this.loginUserName.Size = new System.Drawing.Size(244, 22);
            this.loginUserName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password :";
            // 
            // loginPassword
            // 
            this.loginPassword.Location = new System.Drawing.Point(177, 123);
            this.loginPassword.Margin = new System.Windows.Forms.Padding(4);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.Size = new System.Drawing.Size(244, 22);
            this.loginPassword.TabIndex = 3;
            this.loginPassword.UseSystemPasswordChar = true;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(203, 192);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(100, 28);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // loginCancelBtn
            // 
            this.loginCancelBtn.Location = new System.Drawing.Point(323, 192);
            this.loginCancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loginCancelBtn.Name = "loginCancelBtn";
            this.loginCancelBtn.Size = new System.Drawing.Size(100, 28);
            this.loginCancelBtn.TabIndex = 5;
            this.loginCancelBtn.Text = "Cancel";
            this.loginCancelBtn.UseVisualStyleBackColor = true;
            this.loginCancelBtn.Click += new System.EventHandler(this.loginCancelBtn_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 270);
            this.Controls.Add(this.loginCancelBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.loginPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginUserName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XYZ Company (Pvt) Ltd Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginPassword;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button loginCancelBtn;

        #endregion
    }
}