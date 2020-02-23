namespace SalesOrder
{
    partial class frmSalesOrders
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
            this.btnViewItems = new System.Windows.Forms.Button();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.salesOrderGridView = new System.Windows.Forms.DataGridView();
            this.cmbPayType = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrderGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewItems
            // 
            this.btnViewItems.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnViewItems.Location = new System.Drawing.Point(1025, 290);
            this.btnViewItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewItems.Name = "btnViewItems";
            this.btnViewItems.Padding = new System.Windows.Forms.Padding(1);
            this.btnViewItems.Size = new System.Drawing.Size(107, 36);
            this.btnViewItems.TabIndex = 18;
            this.btnViewItems.Text = "View Items";
            this.btnViewItems.UseVisualStyleBackColor = false;
            this.btnViewItems.Click += new System.EventHandler(this.btnViewItems_Click);
            // 
            // btnAddItems
            // 
            this.btnAddItems.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnAddItems.Location = new System.Drawing.Point(1025, 242);
            this.btnAddItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Padding = new System.Windows.Forms.Padding(1);
            this.btnAddItems.Size = new System.Drawing.Size(107, 36);
            this.btnAddItems.TabIndex = 17;
            this.btnAddItems.Text = "Add Item";
            this.btnAddItems.UseVisualStyleBackColor = false;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnDelete.Location = new System.Drawing.Point(1025, 176);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(1);
            this.btnDelete.Size = new System.Drawing.Size(107, 36);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnEdit.Location = new System.Drawing.Point(1025, 128);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(1);
            this.btnEdit.Size = new System.Drawing.Size(107, 36);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit Order";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnAdd.Location = new System.Drawing.Point(1025, 81);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(1);
            this.btnAdd.Size = new System.Drawing.Size(107, 36);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add Order";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // salesOrderGridView
            // 
            this.salesOrderGridView.AllowUserToAddRows = false;
            this.salesOrderGridView.AllowUserToDeleteRows = false;
            this.salesOrderGridView.AllowUserToResizeColumns = false;
            this.salesOrderGridView.AllowUserToResizeRows = false;
            this.salesOrderGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.salesOrderGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salesOrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesOrderGridView.Location = new System.Drawing.Point(3, 53);
            this.salesOrderGridView.Margin = new System.Windows.Forms.Padding(4);
            this.salesOrderGridView.MultiSelect = false;
            this.salesOrderGridView.Name = "salesOrderGridView";
            this.salesOrderGridView.ReadOnly = true;
            this.salesOrderGridView.RowHeadersVisible = false;
            this.salesOrderGridView.RowHeadersWidth = 51;
            this.salesOrderGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesOrderGridView.Size = new System.Drawing.Size(967, 759);
            this.salesOrderGridView.TabIndex = 19;
            this.salesOrderGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataRowDouble_Click);
            // 
            // cmbPayType
            // 
            this.cmbPayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayType.FormattingEnabled = true;
            this.cmbPayType.Location = new System.Drawing.Point(430, 17);
            this.cmbPayType.Name = "cmbPayType";
            this.cmbPayType.Size = new System.Drawing.Size(172, 24);
            this.cmbPayType.TabIndex = 22;
            this.cmbPayType.SelectedIndexChanged += new System.EventHandler(this.cmbPayType_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(628, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(229, 22);
            this.txtSearch.TabIndex = 21;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnSearch.Location = new System.Drawing.Point(863, 11);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(1);
            this.btnSearch.Size = new System.Drawing.Size(107, 36);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnExport.Location = new System.Drawing.Point(1011, 17);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Padding = new System.Windows.Forms.Padding(1);
            this.btnExport.Size = new System.Drawing.Size(134, 36);
            this.btnExport.TabIndex = 23;
            this.btnExport.Text = "Export to Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmSalesOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1179, 814);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.cmbPayType);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.salesOrderGridView);
            this.Controls.Add(this.btnViewItems);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.MaximizeBox = false;
            this.Name = "frmSalesOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSalesOrders";
            this.Load += new System.EventHandler(this.frmSalesOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesOrderGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewItems;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView salesOrderGridView;
        private System.Windows.Forms.ComboBox cmbPayType;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExport;
    }
}