namespace SalesItem
{
    partial class frmSalesItemAdd
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
            this.cmbSalesItem = new System.Windows.Forms.ComboBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSUnitPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQut = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbSalesItem
            // 
            this.cmbSalesItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesItem.FormattingEnabled = true;
            this.cmbSalesItem.Location = new System.Drawing.Point(241, 90);
            this.cmbSalesItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSalesItem.Name = "cmbSalesItem";
            this.cmbSalesItem.Size = new System.Drawing.Size(345, 24);
            this.cmbSalesItem.TabIndex = 73;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBrand.Location = new System.Drawing.Point(41, 94);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(88, 20);
            this.lblBrand.TabIndex = 72;
            this.lblBrand.Text = "Sales item";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.Location = new System.Drawing.Point(485, 228);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 39);
            this.btnAdd.TabIndex = 71;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSUnitPrice
            // 
            this.txtSUnitPrice.Location = new System.Drawing.Point(241, 170);
            this.txtSUnitPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSUnitPrice.Name = "txtSUnitPrice";
            this.txtSUnitPrice.Size = new System.Drawing.Size(345, 22);
            this.txtSUnitPrice.TabIndex = 70;
            this.txtSUnitPrice.Text = "0.00";
            this.txtSUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPrice.Location = new System.Drawing.Point(41, 171);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(133, 20);
            this.lblPrice.TabIndex = 69;
            this.lblPrice.Text = "Selling unit price";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(241, 132);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(345, 22);
            this.txtQuantity.TabIndex = 68;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuntity_KeyPress);
            // 
            // lblQut
            // 
            this.lblQut.AutoSize = true;
            this.lblQut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblQut.Location = new System.Drawing.Point(41, 134);
            this.lblQut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQut.Name = "lblQut";
            this.lblQut.Size = new System.Drawing.Size(71, 20);
            this.lblQut.TabIndex = 67;
            this.lblQut.Text = "Quantity";
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(241, 49);
            this.cmbProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(345, 24);
            this.cmbProduct.TabIndex = 66;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProduct.Location = new System.Drawing.Point(41, 53);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(67, 20);
            this.lblProduct.TabIndex = 65;
            this.lblProduct.Text = "Product";
            // 
            // frmSalesItemAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(641, 300);
            this.Controls.Add(this.cmbSalesItem);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSUnitPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQut);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.lblProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSalesItemAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesItemAdd";
            this.Load += new System.EventHandler(this.frmSalesItemAdd_Load);
            this.Closed += new System.EventHandler(this.frmSalesItemAdd_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSalesItem;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSUnitPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQut;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label lblProduct;
    }
}