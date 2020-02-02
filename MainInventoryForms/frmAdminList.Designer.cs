namespace MainInventoryForms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnAdminAdd.Location = new System.Drawing.Point(1026, 53);
            this.btnAdminAdd.Name = "btnAdminAdd";
            this.btnAdminAdd.Padding = new System.Windows.Forms.Padding(1);
            this.btnAdminAdd.Size = new System.Drawing.Size(107, 36);
            this.btnAdminAdd.TabIndex = 0;
            this.btnAdminAdd.Text = "Add New";
            this.btnAdminAdd.UseVisualStyleBackColor = false;
            this.btnAdminAdd.Click += new System.EventHandler(this.btnAdminAdd_Click);
            // 
            // btnAdminEdit
            // 
            this.btnAdminEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdminEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnAdminEdit.Location = new System.Drawing.Point(1026, 100);
            this.btnAdminEdit.Name = "btnAdminEdit";
            this.btnAdminEdit.Padding = new System.Windows.Forms.Padding(1);
            this.btnAdminEdit.Size = new System.Drawing.Size(107, 36);
            this.btnAdminEdit.TabIndex = 1;
            this.btnAdminEdit.Text = "Edit";
            this.btnAdminEdit.UseVisualStyleBackColor = false;
            this.btnAdminEdit.Click += new System.EventHandler(this.btnAdminEdit_Click);
            // 
            // btnAdminDelete
            // 
            this.btnAdminDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdminDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnAdminDelete.Location = new System.Drawing.Point(1026, 148);
            this.btnAdminDelete.Name = "btnAdminDelete";
            this.btnAdminDelete.Padding = new System.Windows.Forms.Padding(1);
            this.btnAdminDelete.Size = new System.Drawing.Size(107, 36);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(3, 53);
            this.dataGridViewAdmin.MultiSelect = false;
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.ReadOnly = true;
            this.dataGridViewAdmin.RowHeadersVisible = false;
            this.dataGridViewAdmin.RowHeadersWidth = 51;
            this.dataGridViewAdmin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewAdmin.RowTemplate.Height = 24;
            this.dataGridViewAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAdmin.Size = new System.Drawing.Size(967, 785);
            this.dataGridViewAdmin.TabIndex = 4;
            this.dataGridViewAdmin.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataRowDouble_Click);
            // 
            // btnAdminSearch
            // 
            this.btnAdminSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdminSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnAdminSearch.Location = new System.Drawing.Point(863, 11);
            this.btnAdminSearch.Name = "btnAdminSearch";
            this.btnAdminSearch.Padding = new System.Windows.Forms.Padding(1);
            this.btnAdminSearch.Size = new System.Drawing.Size(107, 36);
            this.btnAdminSearch.TabIndex = 3;
            this.btnAdminSearch.Text = "Search";
            this.btnAdminSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxSearchAdmin
            // 
            this.textBoxSearchAdmin.Location = new System.Drawing.Point(586, 21);
            this.textBoxSearchAdmin.Name = "textBoxSearchAdmin";
            this.textBoxSearchAdmin.Size = new System.Drawing.Size(271, 22);
            this.textBoxSearchAdmin.TabIndex = 5;
            // 
            // frmAdminList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 840);
            this.Controls.Add(this.textBoxSearchAdmin);
            this.Controls.Add(this.dataGridViewAdmin);
            this.Controls.Add(this.btnAdminSearch);
            this.Controls.Add(this.btnAdminDelete);
            this.Controls.Add(this.btnAdminEdit);
            this.Controls.Add(this.btnAdminAdd);
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