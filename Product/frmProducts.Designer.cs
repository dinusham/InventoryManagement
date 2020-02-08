using System;
using System.Windows.Forms;

namespace Product
{
    partial class frmProducts
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
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productGridView
            // 
            this.productGridView.AllowUserToAddRows = false;
            this.productGridView.AllowUserToDeleteRows = false;
            this.productGridView.AllowUserToResizeColumns = false;
            this.productGridView.AllowUserToResizeRows = false;
            this.productGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.productGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(3, 2);
            this.productGridView.MultiSelect = false;
            this.productGridView.Name = "productGridView";
            this.productGridView.ReadOnly = true;
            this.productGridView.RowHeadersVisible = false;
            this.productGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productGridView.Size = new System.Drawing.Size(725, 656);
            this.productGridView.TabIndex = 0;
            this.productGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataRowDouble_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnAdd.Location = new System.Drawing.Point(769, 43);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(1);
            this.btnAdd.Size = new System.Drawing.Size(80, 29);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnEdit.Location = new System.Drawing.Point(769, 81);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(1);
            this.btnEdit.Size = new System.Drawing.Size(80, 29);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnDelete.Location = new System.Drawing.Point(769, 120);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(1);
            this.btnDelete.Size = new System.Drawing.Size(80, 29);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.productGridView);
            this.MaximizeBox = false;
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}