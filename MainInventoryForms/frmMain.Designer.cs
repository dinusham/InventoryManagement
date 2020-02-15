namespace MainInventoryForms
{
    partial class frmMain
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
            this.menuNav = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsTool = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryTool = new System.Windows.Forms.ToolStripMenuItem();
            this.brandsTool = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersTool = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersTool = new System.Windows.Forms.ToolStripMenuItem();
            this.panelUsers = new System.Windows.Forms.Panel();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.panelCategory = new System.Windows.Forms.Panel();
            this.panelBrand = new System.Windows.Forms.Panel();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.panelSupplier = new System.Windows.Forms.Panel();
            this.menuNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuNav
            // 
            this.menuNav.AutoSize = false;
            this.menuNav.BackColor = System.Drawing.Color.White;
            this.menuNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuNav.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuNav.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuNav.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.settingsTool,
            this.categoryTool,
            this.brandsTool,
            this.productToolStripMenuItem,
            this.customersTool,
            this.suppliersTool});
            this.menuNav.Location = new System.Drawing.Point(0, 0);
            this.menuNav.Margin = new System.Windows.Forms.Padding(1);
            this.menuNav.MaximumSize = new System.Drawing.Size(156, 860);
            this.menuNav.MinimumSize = new System.Drawing.Size(156, 860);
            this.menuNav.Name = "menuNav";
            this.menuNav.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuNav.Size = new System.Drawing.Size(156, 860);
            this.menuNav.TabIndex = 0;
            this.menuNav.Text = "menuStrip";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.usersToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(149, 41);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // settingsTool
            // 
            this.settingsTool.BackColor = System.Drawing.Color.SkyBlue;
            this.settingsTool.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.settingsTool.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.settingsTool.Name = "settingsTool";
            this.settingsTool.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.settingsTool.Size = new System.Drawing.Size(149, 41);
            this.settingsTool.Text = "Settings";
            this.settingsTool.Click += new System.EventHandler(this.settingsTool_Click);
            // 
            // categoryTool
            // 
            this.categoryTool.BackColor = System.Drawing.Color.SkyBlue;
            this.categoryTool.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.categoryTool.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.categoryTool.Name = "categoryTool";
            this.categoryTool.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.categoryTool.Size = new System.Drawing.Size(149, 41);
            this.categoryTool.Text = "Category";
            this.categoryTool.Click += new System.EventHandler(this.categoryTool_Click);
            // 
            // brandsTool
            // 
            this.brandsTool.BackColor = System.Drawing.Color.SkyBlue;
            this.brandsTool.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.brandsTool.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.brandsTool.Name = "brandsTool";
            this.brandsTool.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.brandsTool.Size = new System.Drawing.Size(149, 41);
            this.brandsTool.Text = "Brands";
            this.brandsTool.Click += new System.EventHandler(this.brandsTool_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.productToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.productToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.productToolStripMenuItem.Size = new System.Drawing.Size(149, 41);
            this.productToolStripMenuItem.Text = "Products";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // customersTool
            // 
            this.customersTool.BackColor = System.Drawing.Color.SkyBlue;
            this.customersTool.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.customersTool.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.customersTool.Name = "customersTool";
            this.customersTool.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.customersTool.Size = new System.Drawing.Size(149, 41);
            this.customersTool.Text = "Customers";
            this.customersTool.Click += new System.EventHandler(this.customersTool_Click);
            // 
            // suppliersTool
            // 
            this.suppliersTool.BackColor = System.Drawing.Color.SkyBlue;
            this.suppliersTool.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.suppliersTool.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.suppliersTool.Name = "suppliersTool";
            this.suppliersTool.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.suppliersTool.Size = new System.Drawing.Size(149, 41);
            this.suppliersTool.Text = "Suppliers";
            this.suppliersTool.Click += new System.EventHandler(this.suppliersTool_Click);
            // 
            // panelUsers
            // 
            this.panelUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.panelUsers.Location = new System.Drawing.Point(160, 0);
            this.panelUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panelUsers.Size = new System.Drawing.Size(1197, 860);
            this.panelUsers.TabIndex = 0;
            // 
            // panelSettings
            // 
            this.panelSettings.Location = new System.Drawing.Point(160, 0);
            this.panelSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(1197, 860);
            this.panelSettings.TabIndex = 0;
            // 
            // panelCategory
            // 
            this.panelCategory.Location = new System.Drawing.Point(160, 0);
            this.panelCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(1197, 860);
            this.panelCategory.TabIndex = 0;
            // 
            // panelBrand
            // 
            this.panelBrand.Location = new System.Drawing.Point(160, 0);
            this.panelBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBrand.Name = "panelBrand";
            this.panelBrand.Size = new System.Drawing.Size(1197, 860);
            this.panelBrand.TabIndex = 0;
            // 
            // panelProduct
            // 
            this.panelProduct.Location = new System.Drawing.Point(160, 0);
            this.panelProduct.Margin = new System.Windows.Forms.Padding(4);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(1197, 860);
            this.panelProduct.TabIndex = 0;
            // 
            // panelCustomer
            // 
            this.panelCustomer.Location = new System.Drawing.Point(160, 0);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(1197, 860);
            this.panelCustomer.TabIndex = 0;
            // 
            // panelSupplier
            // 
            this.panelSupplier.Location = new System.Drawing.Point(160, 0);
            this.panelSupplier.Name = "panelSupplier";
            this.panelSupplier.Size = new System.Drawing.Size(1197, 860);
            this.panelSupplier.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(230)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1359, 860);
            this.Controls.Add(this.panelSupplier);
            this.Controls.Add(this.panelCustomer);
            this.Controls.Add(this.panelProduct);
            this.Controls.Add(this.panelBrand);
            this.Controls.Add(this.panelCategory);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.panelUsers);
            this.Controls.Add(this.menuNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuNav.ResumeLayout(false);
            this.menuNav.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.MenuStrip menuNav;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsTool;
        private System.Windows.Forms.Panel panelUsers;

        #endregion
        private System.Windows.Forms.ToolStripMenuItem categoryTool;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Panel panelCategory;
        private System.Windows.Forms.ToolStripMenuItem brandsTool;
        private System.Windows.Forms.Panel panelBrand;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.ToolStripMenuItem customersTool;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.ToolStripMenuItem suppliersTool;
        private System.Windows.Forms.Panel panelSupplier;
    }
}