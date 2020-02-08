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
            this.labelsettings.Location = new System.Drawing.Point(54, 43);
            this.labelsettings.Name = "labelsettings";
            this.labelsettings.Size = new System.Drawing.Size(294, 24);
            this.labelsettings.TabIndex = 0;
            this.labelsettings.Text = "User name and password change";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUser.Location = new System.Drawing.Point(59, 106);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(91, 20);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "User name";
            // 
            // labelPsw
            // 
            this.labelPsw.AutoSize = true;
            this.labelPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPsw.Location = new System.Drawing.Point(59, 151);
            this.labelPsw.Name = "labelPsw";
            this.labelPsw.Size = new System.Drawing.Size(142, 20);
            this.labelPsw.TabIndex = 3;
            this.labelPsw.Text = "Current password";
            // 
            // labelPswNw
            // 
            this.labelPswNw.AutoSize = true;
            this.labelPswNw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPswNw.Location = new System.Drawing.Point(59, 193);
            this.labelPswNw.Name = "labelPswNw";
            this.labelPswNw.Size = new System.Drawing.Size(119, 20);
            this.labelPswNw.TabIndex = 4;
            this.labelPswNw.Text = "New password";
            // 
            // labelPswNw2
            // 
            this.labelPswNw2.AutoSize = true;
            this.labelPswNw2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPswNw2.Location = new System.Drawing.Point(59, 232);
            this.labelPswNw2.Name = "labelPswNw2";
            this.labelPswNw2.Size = new System.Drawing.Size(151, 20);
            this.labelPswNw2.TabIndex = 5;
            this.labelPswNw2.Text = "Re-enter password";
            // 
            // txtCurUser
            // 
            this.txtCurUser.Location = new System.Drawing.Point(262, 103);
            this.txtCurUser.Name = "txtCurUser";
            this.txtCurUser.ReadOnly = true;
            this.txtCurUser.Size = new System.Drawing.Size(313, 26);
            this.txtCurUser.TabIndex = 6;
            // 
            // txtCuPsw
            // 
            this.txtCuPsw.Location = new System.Drawing.Point(262, 145);
            this.txtCuPsw.Name = "txtCuPsw";
            this.txtCuPsw.Size = new System.Drawing.Size(313, 26);
            this.txtCuPsw.TabIndex = 8;
            this.txtCuPsw.PasswordChar = '●';
            // 
            // txtNwPsw
            // 
            this.txtNwPsw.Location = new System.Drawing.Point(262, 187);
            this.txtNwPsw.Name = "txtNwPsw";
            this.txtNwPsw.Size = new System.Drawing.Size(313, 26);
            this.txtNwPsw.TabIndex = 9;
            // 
            // txtNwPsw2
            // 
            this.txtNwPsw2.Location = new System.Drawing.Point(262, 226);
            this.txtNwPsw2.Name = "txtNwPsw2";
            this.txtNwPsw2.Size = new System.Drawing.Size(313, 26);
            this.txtNwPsw2.TabIndex = 10;
            this.txtNwPsw2.PasswordChar = '●';
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(481, 281);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 36);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(627, 347);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
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