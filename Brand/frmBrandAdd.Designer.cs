using System;

namespace Brand
{
    partial class frmBrandAdd
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
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.Location = new System.Drawing.Point(410, 181);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 35);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkActive.Location = new System.Drawing.Point(192, 123);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(95, 24);
            this.chkActive.TabIndex = 6;
            this.chkActive.Text = "Is Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // txtBrand
            // 
            this.txtBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBrand.Location = new System.Drawing.Point(192, 68);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(308, 26);
            this.txtBrand.TabIndex = 5;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCategory.Location = new System.Drawing.Point(34, 74);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(103, 20);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Brand Name";
            // 
            // frmBrandAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(556, 267);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblCategory);
            this.MaximizeBox = false;
            this.Name = "frmBrandAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Closed += new System.EventHandler(this.frmBrandAdd_FormClosing);
            this.Text = "frmBrandAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblCategory;
    }
}