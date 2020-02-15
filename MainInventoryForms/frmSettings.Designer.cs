namespace MainInventoryForms
{
    partial class frmSettings
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
            this.components = new System.ComponentModel.Container();
            this.labelsettings = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPsw = new System.Windows.Forms.Label();
            this.labelPswNw = new System.Windows.Forms.Label();
            this.labelPswNw2 = new System.Windows.Forms.Label();
            this.txtCurUser = new System.Windows.Forms.TextBox();
            this.txtCuPsw = new System.Windows.Forms.TextBox();
            this.txtNwPsw = new System.Windows.Forms.TextBox();
            this.txtNwPsw2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelsettings
            // 
            this.labelsettings.AutoSize = true;
            this.labelsettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelsettings.Location = new System.Drawing.Point(43, 34);
            this.labelsettings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelsettings.Name = "labelsettings";
            this.labelsettings.Size = new System.Drawing.Size(294, 24);
            this.labelsettings.TabIndex = 0;
            this.labelsettings.Text = "User name and password change";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUser.Location = new System.Drawing.Point(47, 85);
            this.labelUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(91, 20);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "User name";
            // 
            // labelPsw
            // 
            this.labelPsw.AutoSize = true;
            this.labelPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPsw.Location = new System.Drawing.Point(47, 121);
            this.labelPsw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPsw.Name = "labelPsw";
            this.labelPsw.Size = new System.Drawing.Size(142, 20);
            this.labelPsw.TabIndex = 3;
            this.labelPsw.Text = "Current password";
            // 
            // labelPswNw
            // 
            this.labelPswNw.AutoSize = true;
            this.labelPswNw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPswNw.Location = new System.Drawing.Point(47, 154);
            this.labelPswNw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPswNw.Name = "labelPswNw";
            this.labelPswNw.Size = new System.Drawing.Size(119, 20);
            this.labelPswNw.TabIndex = 4;
            this.labelPswNw.Text = "New password";
            // 
            // labelPswNw2
            // 
            this.labelPswNw2.AutoSize = true;
            this.labelPswNw2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPswNw2.Location = new System.Drawing.Point(47, 186);
            this.labelPswNw2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPswNw2.Name = "labelPswNw2";
            this.labelPswNw2.Size = new System.Drawing.Size(151, 20);
            this.labelPswNw2.TabIndex = 5;
            this.labelPswNw2.Text = "Re-enter password";
            // 
            // txtCurUser
            // 
            this.txtCurUser.Location = new System.Drawing.Point(210, 82);
            this.txtCurUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCurUser.Name = "txtCurUser";
            this.txtCurUser.ReadOnly = true;
            this.txtCurUser.Size = new System.Drawing.Size(251, 22);
            this.txtCurUser.TabIndex = 6;
            // 
            // txtCuPsw
            // 
            this.txtCuPsw.Location = new System.Drawing.Point(210, 116);
            this.txtCuPsw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCuPsw.Name = "txtCuPsw";
            this.txtCuPsw.PasswordChar = '●';
            this.txtCuPsw.Size = new System.Drawing.Size(251, 22);
            this.txtCuPsw.TabIndex = 8;
            // 
            // txtNwPsw
            // 
            this.txtNwPsw.Location = new System.Drawing.Point(210, 150);
            this.txtNwPsw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNwPsw.Name = "txtNwPsw";
            this.txtNwPsw.PasswordChar = '●';
            this.txtNwPsw.Size = new System.Drawing.Size(251, 22);
            this.txtNwPsw.TabIndex = 9;
            // 
            // txtNwPsw2
            // 
            this.txtNwPsw2.Location = new System.Drawing.Point(210, 181);
            this.txtNwPsw2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNwPsw2.Name = "txtNwPsw2";
            this.txtNwPsw2.PasswordChar = '●';
            this.txtNwPsw2.Size = new System.Drawing.Size(251, 22);
            this.txtNwPsw2.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.Location = new System.Drawing.Point(363, 225);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 29);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Update";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.DataMember = "";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(502, 278);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNwPsw2);
            this.Controls.Add(this.txtNwPsw);
            this.Controls.Add(this.txtCuPsw);
            this.Controls.Add(this.txtCurUser);
            this.Controls.Add(this.labelPswNw2);
            this.Controls.Add(this.labelPswNw);
            this.Controls.Add(this.labelPsw);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelsettings);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelsettings;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPsw;
        private System.Windows.Forms.Label labelPswNw;
        private System.Windows.Forms.Label labelPswNw2;
        private System.Windows.Forms.TextBox txtCurUser;
        private System.Windows.Forms.TextBox txtCuPsw;
        private System.Windows.Forms.TextBox txtNwPsw;
        private System.Windows.Forms.TextBox txtNwPsw2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}