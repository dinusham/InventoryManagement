namespace PurchaseItem
{
    partial class frmPurchaseItems
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.purchaseItemGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseItemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnDelete.Location = new System.Drawing.Point(1025, 148);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(1);
            this.btnDelete.Size = new System.Drawing.Size(107, 36);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnEdit.Location = new System.Drawing.Point(1025, 100);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(1);
            this.btnEdit.Size = new System.Drawing.Size(107, 36);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnAdd.Location = new System.Drawing.Point(1025, 53);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(1);
            this.btnAdd.Size = new System.Drawing.Size(107, 36);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // purchaseItemGridView
            // 
            this.purchaseItemGridView.AllowUserToAddRows = false;
            this.purchaseItemGridView.AllowUserToDeleteRows = false;
            this.purchaseItemGridView.AllowUserToResizeColumns = false;
            this.purchaseItemGridView.AllowUserToResizeRows = false;
            this.purchaseItemGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.purchaseItemGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.purchaseItemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseItemGridView.Location = new System.Drawing.Point(4, 4);
            this.purchaseItemGridView.Margin = new System.Windows.Forms.Padding(4);
            this.purchaseItemGridView.MultiSelect = false;
            this.purchaseItemGridView.Name = "purchaseItemGridView";
            this.purchaseItemGridView.ReadOnly = true;
            this.purchaseItemGridView.RowHeadersVisible = false;
            this.purchaseItemGridView.RowHeadersWidth = 51;
            this.purchaseItemGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.purchaseItemGridView.Size = new System.Drawing.Size(967, 805);
            this.purchaseItemGridView.TabIndex = 10;
            this.purchaseItemGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataRowDouble_Click);
            // 
            // frmPurchaseItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1179, 814);
            this.Controls.Add(this.purchaseItemGridView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPurchaseItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseItems";
            this.Load += new System.EventHandler(this.frmPurchaseItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseItemGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView purchaseItemGridView;
    }
}