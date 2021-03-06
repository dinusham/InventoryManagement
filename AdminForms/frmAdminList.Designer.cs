﻿namespace AdminForms
{
    partial class frmAdminList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdminAdd = new System.Windows.Forms.Button();
            this.btnAdminEdit = new System.Windows.Forms.Button();
            this.btnAdminDelete = new System.Windows.Forms.Button();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.btnAdminSearch = new System.Windows.Forms.Button();
            this.textBoxSearchAdmin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdminAdd
            // 
            this.btnAdminAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdminAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnAdminAdd.Location = new System.Drawing.Point(769, 43);
            this.btnAdminAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdminAdd.Name = "btnAdminAdd";
            this.btnAdminAdd.Padding = new System.Windows.Forms.Padding(1);
            this.btnAdminAdd.Size = new System.Drawing.Size(80, 29);
            this.btnAdminAdd.TabIndex = 0;
            this.btnAdminAdd.Text = "Add New";
            this.btnAdminAdd.UseVisualStyleBackColor = false;
            this.btnAdminAdd.Click += new System.EventHandler(this.btnAdminAdd_Click);
            // 
            // btnAdminEdit
            // 
            this.btnAdminEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdminEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnAdminEdit.Location = new System.Drawing.Point(769, 81);
            this.btnAdminEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdminEdit.Name = "btnAdminEdit";
            this.btnAdminEdit.Padding = new System.Windows.Forms.Padding(1);
            this.btnAdminEdit.Size = new System.Drawing.Size(80, 29);
            this.btnAdminEdit.TabIndex = 1;
            this.btnAdminEdit.Text = "Edit";
            this.btnAdminEdit.UseVisualStyleBackColor = false;
            this.btnAdminEdit.Click += new System.EventHandler(this.btnAdminEdit_Click);
            // 
            // btnAdminDelete
            // 
            this.btnAdminDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdminDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnAdminDelete.Location = new System.Drawing.Point(769, 120);
            this.btnAdminDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdminDelete.Name = "btnAdminDelete";
            this.btnAdminDelete.Padding = new System.Windows.Forms.Padding(1);
            this.btnAdminDelete.Size = new System.Drawing.Size(80, 29);
            this.btnAdminDelete.TabIndex = 2;
            this.btnAdminDelete.Text = "Delete";
            this.btnAdminDelete.UseVisualStyleBackColor = false;
            this.btnAdminDelete.Click += new System.EventHandler(this.btnAdminDelete_Click);
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.AllowUserToAddRows = false;
            this.dataGridViewAdmin.AllowUserToDeleteRows = false;
            this.dataGridViewAdmin.AllowUserToResizeColumns = false;
            this.dataGridViewAdmin.AllowUserToResizeRows = false;
            this.dataGridViewAdmin.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(2, 43);
            this.dataGridViewAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAdmin.MultiSelect = false;
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.ReadOnly = true;
            this.dataGridViewAdmin.RowHeadersVisible = false;
            this.dataGridViewAdmin.RowHeadersWidth = 51;
            this.dataGridViewAdmin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewAdmin.RowTemplate.Height = 24;
            this.dataGridViewAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAdmin.Size = new System.Drawing.Size(725, 617);
            this.dataGridViewAdmin.TabIndex = 4;
            this.dataGridViewAdmin.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataRowDouble_Click);
            // 
            // btnAdminSearch
            // 
            this.btnAdminSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdminSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnAdminSearch.Location = new System.Drawing.Point(647, 9);
            this.btnAdminSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdminSearch.Name = "btnAdminSearch";
            this.btnAdminSearch.Padding = new System.Windows.Forms.Padding(1);
            this.btnAdminSearch.Size = new System.Drawing.Size(80, 29);
            this.btnAdminSearch.TabIndex = 3;
            this.btnAdminSearch.Text = "Search";
            this.btnAdminSearch.UseVisualStyleBackColor = false;
            this.btnAdminSearch.Click += new System.EventHandler(this.btnAdminSearch_Click);
            // 
            // textBoxSearchAdmin
            // 
            this.textBoxSearchAdmin.Location = new System.Drawing.Point(440, 17);
            this.textBoxSearchAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSearchAdmin.Name = "textBoxSearchAdmin";
            this.textBoxSearchAdmin.Size = new System.Drawing.Size(204, 20);
            this.textBoxSearchAdmin.TabIndex = 5;
            // 
            // frmAdminList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.textBoxSearchAdmin);
            this.Controls.Add(this.dataGridViewAdmin);
            this.Controls.Add(this.btnAdminSearch);
            this.Controls.Add(this.btnAdminDelete);
            this.Controls.Add(this.btnAdminEdit);
            this.Controls.Add(this.btnAdminAdd);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmAdminList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAdminList";
            this.Load += new System.EventHandler(this.frmAdminList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminAdd;
        private System.Windows.Forms.Button btnAdminEdit;
        private System.Windows.Forms.Button btnAdminDelete;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.Button btnAdminSearch;
        private System.Windows.Forms.TextBox textBoxSearchAdmin;
    }
}