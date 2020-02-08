namespace Product
{
    partial class frmProductAdd
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblPCode = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPname = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.Location = new System.Drawing.Point(336, 256);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 28);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(163, 161);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(241, 20);
            this.txtTitle.TabIndex = 16;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbltitle.Location = new System.Drawing.Point(37, 164);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(35, 17);
            this.lbltitle.TabIndex = 15;
            this.lbltitle.Text = "Title";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(163, 117);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(241, 20);
            this.txtCode.TabIndex = 14;
            // 
            // lblPCode
            // 
            this.lblPCode.AutoSize = true;
            this.lblPCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPCode.Location = new System.Drawing.Point(37, 120);
            this.lblPCode.Name = "lblPCode";
            this.lblPCode.Size = new System.Drawing.Size(41, 17);
            this.lblPCode.TabIndex = 13;
            this.lblPCode.Text = "Code";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(163, 82);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(241, 20);
            this.txtName.TabIndex = 12;
            // 
            // lblPname
            // 
            this.lblPname.AutoSize = true;
            this.lblPname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPname.Location = new System.Drawing.Point(37, 82);
            this.lblPname.Name = "lblPname";
            this.lblPname.Size = new System.Drawing.Size(45, 17);
            this.lblPname.TabIndex = 11;
            this.lblPname.Text = "Name";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(163, 36);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(241, 21);
            this.cmbCategory.TabIndex = 10;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCategory.Location = new System.Drawing.Point(37, 40);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 17);
            this.lblCategory.TabIndex = 9;
            this.lblCategory.Text = "Category";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(163, 208);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(67, 17);
            this.chkActive.TabIndex = 18;
            this.chkActive.Text = "Is Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // frmProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(452, 307);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblPCode);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPname);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.MaximizeBox = false;
            this.Name = "frmProductAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductAdd";
            this.Load += new System.EventHandler(this.frmProductAdd_Load);
            this.Closed += new System.EventHandler(this.frmProductAdd_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblPCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPname;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.CheckBox chkActive;
    }
}