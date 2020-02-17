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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBrandInA = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBrandA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblCaInA = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCaA = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.lblCInA = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblCA = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSInA = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lblSA = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPInA = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblPA = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuNav.SuspendLayout();
            this.panelUsers.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.panelCategory.SuspendLayout();
            this.panelBrand.SuspendLayout();
            this.panelProduct.SuspendLayout();
            this.panelCustomer.SuspendLayout();
            this.panelSupplier.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.usersTool.Size = new System.Drawing.Size(141, 41);
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
            this.categoryTool.Size = new System.Drawing.Size(141, 41);
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
            this.brandsTool.Size = new System.Drawing.Size(141, 41);
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
            this.productTool.Size = new System.Drawing.Size(141, 41);
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
            this.customersTool.Size = new System.Drawing.Size(141, 41);
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
            this.suppliersTool.Size = new System.Drawing.Size(141, 41);
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
            this.purchaseOrderTool.Size = new System.Drawing.Size(141, 41);
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
            this.settingsTool.Size = new System.Drawing.Size(141, 41);
            this.settingsTool.Text = "Settings";
            this.settingsTool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsTool.Click += new System.EventHandler(this.settingsTool_Click);
            // 
            // panelUsers
            // 
            this.panelUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.panelUsers.Controls.Add(this.panelSettings);
            this.panelUsers.Location = new System.Drawing.Point(513, 452);
            this.panelUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panelUsers.Size = new System.Drawing.Size(1197, 860);
            this.panelUsers.TabIndex = 0;
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.panelSettings.Controls.Add(this.panelCategory);
            this.panelSettings.Location = new System.Drawing.Point(14, 24);
            this.panelSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(1197, 860);
            this.panelSettings.TabIndex = 0;
            // 
            // panelCategory
            // 
            this.panelCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.panelCategory.Controls.Add(this.panelBrand);
            this.panelCategory.Location = new System.Drawing.Point(19, 16);
            this.panelCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(1197, 860);
            this.panelCategory.TabIndex = 0;
            // 
            // panelBrand
            // 
            this.panelBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.panelBrand.Controls.Add(this.panelProduct);
            this.panelBrand.Location = new System.Drawing.Point(17, 19);
            this.panelBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBrand.Name = "panelBrand";
            this.panelBrand.Size = new System.Drawing.Size(1197, 860);
            this.panelBrand.TabIndex = 0;
            // 
            // panelProduct
            // 
            this.panelProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.panelProduct.Controls.Add(this.panelCustomer);
            this.panelProduct.Location = new System.Drawing.Point(20, 4);
            this.panelProduct.Margin = new System.Windows.Forms.Padding(4);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(1197, 860);
            this.panelProduct.TabIndex = 0;
            // 
            // panelCustomer
            // 
            this.panelCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.panelCustomer.Controls.Add(this.panelSupplier);
            this.panelCustomer.Location = new System.Drawing.Point(20, 12);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(1197, 860);
            this.panelCustomer.TabIndex = 0;
            // 
            // panelSupplier
            // 
            this.panelSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.panelSupplier.Controls.Add(this.panelPurchaseOrder);
            this.panelSupplier.Location = new System.Drawing.Point(15, 18);
            this.panelSupplier.Name = "panelSupplier";
            this.panelSupplier.Size = new System.Drawing.Size(1197, 860);
            this.panelSupplier.TabIndex = 0;
            // 
            // panelPurchaseOrder
            // 
            this.panelPurchaseOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.panelPurchaseOrder.Location = new System.Drawing.Point(18, 24);
            this.panelPurchaseOrder.Name = "panelPurchaseOrder";
            this.panelPurchaseOrder.Size = new System.Drawing.Size(1197, 860);
            this.panelPurchaseOrder.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(1)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Brand";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(8, 51);
            this.lbl.Name = "lbl";
            this.lbl.Padding = new System.Windows.Forms.Padding(6, 38, 150, 10);
            this.lbl.Size = new System.Drawing.Size(196, 74);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "    ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBrandInA);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblBrandA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Location = new System.Drawing.Point(167, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 213);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // lblBrandInA
            // 
            this.lblBrandInA.AutoSize = true;
            this.lblBrandInA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.lblBrandInA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblBrandInA.ForeColor = System.Drawing.Color.White;
            this.lblBrandInA.Location = new System.Drawing.Point(15, 171);
            this.lblBrandInA.Name = "lblBrandInA";
            this.lblBrandInA.Size = new System.Drawing.Size(25, 26);
            this.lblBrandInA.TabIndex = 13;
            this.lblBrandInA.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "In Active";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Active";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 132);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(6, 38, 150, 10);
            this.label2.Size = new System.Drawing.Size(196, 74);
            this.label2.TabIndex = 3;
            this.label2.Text = "    ";
            // 
            // lblBrandA
            // 
            this.lblBrandA.AutoSize = true;
            this.lblBrandA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.lblBrandA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblBrandA.ForeColor = System.Drawing.Color.White;
            this.lblBrandA.Location = new System.Drawing.Point(15, 88);
            this.lblBrandA.Name = "lblBrandA";
            this.lblBrandA.Size = new System.Drawing.Size(25, 26);
            this.lblBrandA.TabIndex = 11;
            this.lblBrandA.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(1)))), ((int)(((byte)(67)))));
            this.label4.Location = new System.Drawing.Point(7, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Category";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblCaInA);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.lblCaA);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Location = new System.Drawing.Point(408, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(214, 213);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            // 
            // lblCaInA
            // 
            this.lblCaInA.AutoSize = true;
            this.lblCaInA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.lblCaInA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblCaInA.ForeColor = System.Drawing.Color.White;
            this.lblCaInA.Location = new System.Drawing.Point(15, 171);
            this.lblCaInA.Name = "lblCaInA";
            this.lblCaInA.Size = new System.Drawing.Size(25, 26);
            this.lblCaInA.TabIndex = 15;
            this.lblCaInA.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(10, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "In Active";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(10, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Active";
            // 
            // lblCaA
            // 
            this.lblCaA.AutoSize = true;
            this.lblCaA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.lblCaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblCaA.ForeColor = System.Drawing.Color.White;
            this.lblCaA.Location = new System.Drawing.Point(15, 88);
            this.lblCaA.Name = "lblCaA";
            this.lblCaA.Size = new System.Drawing.Size(25, 26);
            this.lblCaA.TabIndex = 14;
            this.lblCaA.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 132);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(6, 38, 150, 10);
            this.label9.Size = new System.Drawing.Size(196, 74);
            this.label9.TabIndex = 16;
            this.label9.Text = "    ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 51);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(6, 38, 150, 10);
            this.label3.Size = new System.Drawing.Size(196, 74);
            this.label3.TabIndex = 16;
            this.label3.Text = "    ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.lblCInA);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.lblCA);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Location = new System.Drawing.Point(650, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(214, 213);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(1)))), ((int)(((byte)(67)))));
            this.label26.Location = new System.Drawing.Point(8, 18);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(97, 25);
            this.label26.TabIndex = 16;
            this.label26.Text = "Customer";
            // 
            // lblCInA
            // 
            this.lblCInA.AutoSize = true;
            this.lblCInA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.lblCInA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblCInA.ForeColor = System.Drawing.Color.White;
            this.lblCInA.Location = new System.Drawing.Point(15, 171);
            this.lblCInA.Name = "lblCInA";
            this.lblCInA.Size = new System.Drawing.Size(25, 26);
            this.lblCInA.TabIndex = 13;
            this.lblCInA.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(15, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "In Active";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(15, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 20);
            this.label15.TabIndex = 14;
            this.label15.Text = "Active";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(8, 132);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(6, 38, 150, 10);
            this.label16.Size = new System.Drawing.Size(196, 74);
            this.label16.TabIndex = 3;
            this.label16.Text = "    ";
            // 
            // lblCA
            // 
            this.lblCA.AutoSize = true;
            this.lblCA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.lblCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblCA.ForeColor = System.Drawing.Color.White;
            this.lblCA.Location = new System.Drawing.Point(15, 88);
            this.lblCA.Name = "lblCA";
            this.lblCA.Size = new System.Drawing.Size(25, 26);
            this.lblCA.TabIndex = 11;
            this.lblCA.Text = "0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(8, 51);
            this.label27.Name = "label27";
            this.label27.Padding = new System.Windows.Forms.Padding(6, 38, 150, 10);
            this.label27.Size = new System.Drawing.Size(196, 74);
            this.label27.TabIndex = 0;
            this.label27.Text = "    ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblSInA);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.lblSA);
            this.groupBox2.Controls.Add(this.label33);
            this.groupBox2.Location = new System.Drawing.Point(886, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 213);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(1)))), ((int)(((byte)(67)))));
            this.label11.Location = new System.Drawing.Point(9, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "Supplier";
            // 
            // lblSInA
            // 
            this.lblSInA.AutoSize = true;
            this.lblSInA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.lblSInA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblSInA.ForeColor = System.Drawing.Color.White;
            this.lblSInA.Location = new System.Drawing.Point(15, 171);
            this.lblSInA.Name = "lblSInA";
            this.lblSInA.Size = new System.Drawing.Size(25, 26);
            this.lblSInA.TabIndex = 13;
            this.lblSInA.Text = "0";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(15, 141);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(73, 20);
            this.label29.TabIndex = 15;
            this.label29.Text = "In Active";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(15, 61);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(55, 20);
            this.label30.TabIndex = 14;
            this.label30.Text = "Active";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(8, 132);
            this.label31.Name = "label31";
            this.label31.Padding = new System.Windows.Forms.Padding(6, 38, 150, 10);
            this.label31.Size = new System.Drawing.Size(196, 74);
            this.label31.TabIndex = 3;
            this.label31.Text = "    ";
            // 
            // lblSA
            // 
            this.lblSA.AutoSize = true;
            this.lblSA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.lblSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblSA.ForeColor = System.Drawing.Color.White;
            this.lblSA.Location = new System.Drawing.Point(15, 88);
            this.lblSA.Name = "lblSA";
            this.lblSA.Size = new System.Drawing.Size(25, 26);
            this.lblSA.TabIndex = 11;
            this.lblSA.Text = "0";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(8, 51);
            this.label33.Name = "label33";
            this.label33.Padding = new System.Windows.Forms.Padding(6, 38, 150, 10);
            this.label33.Size = new System.Drawing.Size(196, 74);
            this.label33.TabIndex = 0;
            this.label33.Text = "    ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblPInA);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.lblPA);
            this.groupBox3.Controls.Add(this.label35);
            this.groupBox3.Location = new System.Drawing.Point(1121, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(214, 213);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // lblPInA
            // 
            this.lblPInA.AutoSize = true;
            this.lblPInA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.lblPInA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblPInA.ForeColor = System.Drawing.Color.White;
            this.lblPInA.Location = new System.Drawing.Point(15, 171);
            this.lblPInA.Name = "lblPInA";
            this.lblPInA.Size = new System.Drawing.Size(25, 26);
            this.lblPInA.TabIndex = 13;
            this.lblPInA.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(15, 141);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 20);
            this.label18.TabIndex = 15;
            this.label18.Text = "In Active";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(15, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 20);
            this.label19.TabIndex = 14;
            this.label19.Text = "Active";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(8, 132);
            this.label20.Name = "label20";
            this.label20.Padding = new System.Windows.Forms.Padding(6, 38, 150, 10);
            this.label20.Size = new System.Drawing.Size(196, 74);
            this.label20.TabIndex = 3;
            this.label20.Text = "    ";
            // 
            // lblPA
            // 
            this.lblPA.AutoSize = true;
            this.lblPA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.lblPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblPA.ForeColor = System.Drawing.Color.White;
            this.lblPA.Location = new System.Drawing.Point(15, 88);
            this.lblPA.Name = "lblPA";
            this.lblPA.Size = new System.Drawing.Size(25, 26);
            this.lblPA.TabIndex = 11;
            this.lblPA.Text = "0";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(154)))), ((int)(((byte)(225)))));
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(8, 51);
            this.label35.Name = "label35";
            this.label35.Padding = new System.Windows.Forms.Padding(6, 38, 150, 10);
            this.label35.Size = new System.Drawing.Size(196, 74);
            this.label35.TabIndex = 0;
            this.label35.Text = "    ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(1)))), ((int)(((byte)(67)))));
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Product";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1359, 860);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
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
            this.panelUsers.ResumeLayout(false);
            this.panelSettings.ResumeLayout(false);
            this.panelCategory.ResumeLayout(false);
            this.panelBrand.ResumeLayout(false);
            this.panelProduct.ResumeLayout(false);
            this.panelCustomer.ResumeLayout(false);
            this.panelSupplier.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private Label label1;
        private Label lbl;
        private GroupBox groupBox1;
        private Label label4;
        private GroupBox groupBox6;
        private Label lblBrandA;
        private Label lblBrandInA;
        private Label lblCaInA;
        private Label lblCaA;
        private Label label2;
        private Label label7;
        private Label label8;
        private Label label3;
        private Label label9;
        private Label label12;
        private Label label10;
        private GroupBox groupBox5;
        private Label label26;
        private Label lblCInA;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label lblCA;
        private Label label27;
        private GroupBox groupBox2;
        private Label label11;
        private Label lblSInA;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label lblSA;
        private Label label33;
        private GroupBox groupBox3;
        private Label label5;
        private Label lblPInA;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label lblPA;
        private Label label35;
    }
}