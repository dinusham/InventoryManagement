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
            this.cmbSalesItem.Location = new System.Drawing.Point(181, 73);
            this.cmbSalesItem.Name = "cmbSalesItem";
            this.cmbSalesItem.Size = new System.Drawing.Size(260, 21);
            this.cmbSalesItem.TabIndex = 73;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBrand.Location = new System.Drawing.Point(31, 76);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(73, 17);
            this.lblBrand.TabIndex = 72;
            this.lblBrand.Text = "Sales item";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.Location = new System.Drawing.Point(364, 185);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 32);
            this.btnAdd.TabIndex = 71;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSUnitPrice
            // 
            this.txtSUnitPrice.Location = new System.Drawing.Point(181, 138);
            this.txtSUnitPrice.Name = "txtSUnitPrice";
            this.txtSUnitPrice.Size = new System.Drawing.Size(260, 20);
            this.txtSUnitPrice.TabIndex = 70;
            this.txtSUnitPrice.Text = "0.00";
            this.txtSUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPrice.Location = new System.Drawing.Point(31, 139);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(112, 17);
            this.lblPrice.TabIndex = 69;
            this.lblPrice.Text = "Selling unit price";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(181, 107);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(260, 20);
            this.txtQuantity.TabIndex = 68;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuntity_KeyPress);
            // 
            // lblQut
            // 
            this.lblQut.AutoSize = true;
            this.lblQut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblQut.Location = new System.Drawing.Point(31, 109);
            this.lblQut.Name = "lblQut";
            this.lblQut.Size = new System.Drawing.Size(61, 17);
            this.lblQut.TabIndex = 67;
            this.lblQut.Text = "Quantity";
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(181, 40);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(260, 21);
            this.cmbProduct.TabIndex = 66;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProduct.Location = new System.Drawing.Point(31, 43);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(57, 17);
            this.lblProduct.TabIndex = 65;
            this.lblProduct.Text = "Product";
            // 
            // frmSalesItemAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(481, 244);
            this.Controls.Add(this.cmbSalesItem);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSUnitPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQut);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.lblProduct);
            this.Name = "frmSalesItemAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesItemAdd";
            this.Load += new System.EventHandler(this.frmSalesItemAdd_Load);
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