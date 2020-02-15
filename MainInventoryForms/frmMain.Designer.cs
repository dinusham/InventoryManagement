using System;
using System.Drawing;
using System.Windows.Forms;

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
            this.dashboardTool = new System.Windows.Forms.ToolStripMenuItem();
            this.usersTool = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryTool = new System.Windows.Forms.ToolStripMenuItem();
            this.brandsTool = new System.Windows.Forms.ToolStripMenuItem();
            this.productTool = new System.Windows.Forms.ToolStripMenuItem();
            this.customersTool = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersTool = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrderTool = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsTool = new System.Windows.Forms.ToolStripMenuItem();
            this.panelUsers = new System.Windows.Forms.Panel();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.panelCategory = new System.Windows.Forms.Panel();
            this.panelBrand = new System.Windows.Forms.Panel();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.panelSupplier = new System.Windows.Forms.Panel();
            this.panelPurchaseOrder = new System.Windows.Forms.Panel();
            this.menuNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuNav
            // 
            this.menuNav.AutoSize = false;
            this.menuNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(1)))), ((int)(((byte)(67)))));
            this.menuNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuNav.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuNav.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuNav.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardTool,
            this.usersTool,
            this.categoryTool,
            this.brandsTool,
            this.productTool,
            this.customersTool,
            this.suppliersTool,
            this.purchaseOrderTool,
            this.settingsTool});
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
            // dashboardTool
            // 
            this.dashboardTool.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dashboardTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(1)))), ((int)(((byte)(67)))));
            this.dashboardTool.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dashboardTool.ForeColor = System.Drawing.Color.White;
            this.dashboardTool.Margin = new System.Windows.Forms.Padding(8, 5, 0, 5);
            this.dashboardTool.Name = "dashboardTool";
            this.dashboardTool.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.dashboardTool.Size = new System.Drawing.Size(141, 41);
            this.dashboardTool.Text = "Dashboard";
            this.dashboardTool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardTool.Click += new System.EventHandler(this.dashboardTool_Click);
            // 
            // usersTool
            // 
            this.usersTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(1)))), ((int)(((byte)(67)))));
            this.usersTool.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.usersTool.ForeColor = System.Drawing.Color.White;
            this.usersTool.Margin = new System.Windows.Forms.Padding(8, 5, 0, 5);
            this.usersTool.Name = "usersTool";
            this.usersTool.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.usersTool.Size = new System.Drawing.Size(149, 41);
            this.usersTool.Text = "Users";
            this.usersTool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersTool.Click += new System.EventHandler(this.usersTool_Click);
            // 
            // categoryTool
            // 
            this.categoryTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(1)))), ((int)(((byte)(67)))));
            this.categoryTool.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.categoryTool.ForeColor = System.Drawing.Color.White;
            this.categoryTool.Margin = new System.Windows.Forms.Padding(8, 5, 0, 5);
            this.categoryTool.Name = "categoryTool";
            this.categoryTool.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.categoryTool.Size = new System.Drawing.Size(149, 41);
            this.categoryTool.Text = "Category";
            this.categoryTool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoryTool.Click += new System.EventHandler(this.categoryTool_Click);
            // 
            // brandsTool
            // 
            this.brandsTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(1)))), ((int)(((byte)(67)))));
            this.brandsTool.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.brandsTool.ForeColor = System.Drawing.Color.White;
            this.brandsTool.Margin = new System.Windows.Forms.Padding(8, 5, 0, 5);
            this.brandsTool.Name = "brandsTool";
            this.brandsTool.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.brandsTool.Size = new System.Drawing.Size(149, 41);
            this.brandsTool.Text = "Brands";
            this.brandsTool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brandsTool.Click += new System.EventHandler(this.brandsTool_Click);
            // 
            // productTool
            // 
            this.productTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(1)))), ((int)(((byte)(67)))));
            this.productTool.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.productTool.ForeColor = System.Drawing.Color.White;
            this.productTool.Margin = new System.Windows.Forms.Padding(8, 5, 0, 5);
            this.productTool.Name = "productTool";
            this.productTool.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.productTool.Size = new System.Drawing.Size(149, 41);
            this.productTool.Text = "Products";
            this.productTool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productTool.Click += new System.EventHandler(this.productTool_Click);
            // 
            // customersTool
            // 
            this.customersTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(1)))), ((int)(((byte)(67)))));
            this.customersTool.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.customersTool.ForeColor = System.Drawing.Color.White;
            this.customersTool.Margin = new System.Windows.Forms.Padding(8, 5, 0, 5);
            this.customersTool.Name = "customersTool";
            this.customersTool.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.customersTool.Size = new System.Drawing.Size(149, 41);
            this.customersTool.Text = "Customers";
            this.customersTool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customersTool.Click += new System.EventHandler(this.customersTool_Click);
            // 
            // suppliersTool
            // 
            this.suppliersTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(1)))), ((int)(((byte)(67)))));
            this.suppliersTool.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.suppliersTool.ForeColor = System.Drawing.Color.White;
            this.suppliersTool.Margin = new System.Windows.Forms.Padding(8, 5, 0, 5);
            this.suppliersTool.Name = "suppliersTool";
            this.suppliersTool.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.suppliersTool.Size = new System.Drawing.Size(149, 41);
            this.suppliersTool.Text = "Suppliers";
            this.suppliersTool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.suppliersTool.Click += new System.EventHandler(this.suppliersTool_Click);
            // 
            // purchaseOrderTool
            // 
            this.purchaseOrderTool.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.purchaseOrderTool.ForeColor = System.Drawing.Color.White;
            this.purchaseOrderTool.Margin = new System.Windows.Forms.Padding(8, 5, 0, 5);
            this.purchaseOrderTool.Name = "purchaseOrderTool";
            this.purchaseOrderTool.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.purchaseOrderTool.Size = new System.Drawing.Size(149, 41);
            this.purchaseOrderTool.Text = "Purchase Order";
            this.purchaseOrderTool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.purchaseOrderTool.Click += new System.EventHandler(this.purchaseOrderTool_Click);
            // 
            // settingsTool
            // 
            this.settingsTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(1)))), ((int)(((byte)(67)))));
            this.settingsTool.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.settingsTool.ForeColor = System.Drawing.Color.White;
            this.settingsTool.Margin = new System.Windows.Forms.Padding(8, 5, 0, 5);
            this.settingsTool.Name = "settingsTool";
            this.settingsTool.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.settingsTool.Size = new System.Drawing.Size(149, 41);
            this.settingsTool.Text = "Settings";
            this.settingsTool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsTool.Click += new System.EventHandler(this.settingsTool_Click);
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
            this.panelSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.panelSettings.Location = new System.Drawing.Point(160, 0);
            this.panelSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(1197, 860);
            this.panelSettings.TabIndex = 0;
            // 
            // panelCategory
            // 
            this.panelCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.panelCategory.Location = new System.Drawing.Point(160, 0);
            this.panelCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(1197, 860);
            this.panelCategory.TabIndex = 0;
            // 
            // panelBrand
            // 
            this.panelBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.panelBrand.Location = new System.Drawing.Point(160, 0);
            this.panelBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBrand.Name = "panelBrand";
            this.panelBrand.Size = new System.Drawing.Size(1197, 860);
            this.panelBrand.TabIndex = 0;
            // 
            // panelProduct
            // 
            this.panelProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.panelProduct.Location = new System.Drawing.Point(160, 0);
            this.panelProduct.Margin = new System.Windows.Forms.Padding(4);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(1197, 860);
            this.panelProduct.TabIndex = 0;
            // 
            // panelCustomer
            // 
            this.panelCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.panelCustomer.Location = new System.Drawing.Point(160, 0);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(1197, 860);
            this.panelCustomer.TabIndex = 0;
            // 
            // panelSupplier
            // 
            this.panelSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.panelSupplier.Location = new System.Drawing.Point(160, 0);
            this.panelSupplier.Name = "panelSupplier";
            this.panelSupplier.Size = new System.Drawing.Size(1197, 860);
            this.panelSupplier.TabIndex = 0;
            // 
            // panelPurchaseOrder
            // 
            this.panelPurchaseOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.panelPurchaseOrder.Location = new System.Drawing.Point(160, 0);
            this.panelPurchaseOrder.Name = "panelPurchaseOrder";
            this.panelPurchaseOrder.Size = new System.Drawing.Size(1197, 860);
            this.panelPurchaseOrder.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1359, 860);
            this.Controls.Add(this.panelPurchaseOrder);
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

        private void MenuItem_MouseHover(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).ForeColor = Color.Yellow;
        }

        private System.Windows.Forms.MenuStrip menuNav;
        private System.Windows.Forms.ToolStripMenuItem usersTool;
        private System.Windows.Forms.Panel panelUsers;

        #endregion
        private System.Windows.Forms.ToolStripMenuItem categoryTool;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Panel panelCategory;
        private System.Windows.Forms.ToolStripMenuItem brandsTool;
        private System.Windows.Forms.Panel panelBrand;
        private System.Windows.Forms.ToolStripMenuItem productTool;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.ToolStripMenuItem customersTool;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.ToolStripMenuItem suppliersTool;
        private System.Windows.Forms.Panel panelSupplier;
        private System.Windows.Forms.ToolStripMenuItem dashboardTool;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderTool;
        private System.Windows.Forms.Panel panelPurchaseOrder;
        private System.Windows.Forms.ToolStripMenuItem settingsTool;
    }
}