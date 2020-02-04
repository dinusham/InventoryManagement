namespace Brand
{
    partial class frmBrands
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
            this.brandGridView = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.brandGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // brandGridView
            // 
            this.brandGridView.AllowUserToAddRows = false;
            this.brandGridView.AllowUserToDeleteRows = false;
            this.brandGridView.AllowUserToResizeColumns = false;
            this.brandGridView.AllowUserToResizeRows = false;
            this.brandGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.brandGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.brandGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brandGridView.Location = new System.Drawing.Point(4, 3);
            this.brandGridView.MultiSelect = false;
            this.brandGridView.Name = "brandGridView";
            this.brandGridView.ReadOnly = true;
            this.brandGridView.RowHeadersVisible = false;
            this.brandGridView.RowHeadersWidth = 51;
            this.brandGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.brandGridView.RowTemplate.Height = 24;
            this.brandGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.brandGridView.Size = new System.Drawing.Size(967, 807);
            this.brandGridView.TabIndex = 0;
            this.brandGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataRowDouble_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnAdd.Location = new System.Drawing.Point(1025, 53);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(1);
            this.btnAdd.Size = new System.Drawing.Size(107, 36);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnEdit.Location = new System.Drawing.Point(1025, 100);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(1);
            this.btnEdit.Size = new System.Drawing.Size(107, 36);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnDelete.Location = new System.Drawing.Point(1025, 148);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(1);
            this.btnDelete.Size = new System.Drawing.Size(107, 36);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmBrands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 813);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.brandGridView);
            this.MaximizeBox = false;
            this.Name = "frmBrands";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmBrands";
            this.Load += new System.EventHandler(this.frmBrands_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brandGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView brandGridView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}