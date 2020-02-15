using AdminForms;
using CategoryForms;
using Brand;
using InventoryDataAccess;
using System;
using System.Windows.Forms;
using Product;
using Customer;
using Supplier;
using System.Drawing;

namespace MainInventoryForms
{
    public partial class frmMain : Form
    {
        private AdminDTO adminDto;

        public frmMain(AdminDTO adminDto)
        {
            this.adminDto = adminDto;
            InitializeComponent();
            ManageComponents();
        }

        private void ManageComponents()
        {
            if (!adminDto.IsAdmin)
                usersToolStripMenuItem.Visible = false;
            //else
            //    settingsTool.Visible = false;
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usersToolStripMenuItem.BackColor = Color.RoyalBlue;
            brandsTool.BackColor = Color.SkyBlue;
            categoryTool.BackColor = Color.SkyBlue;
            settingsTool.BackColor = Color.SkyBlue;
            productToolStripMenuItem.BackColor = Color.SkyBlue;
            customersTool.BackColor = Color.SkyBlue;
            suppliersTool.BackColor = Color.SkyBlue;

            panelUsers.Visible = true;
            panelCategory.Visible = false;
            panelSettings.Visible = false;
            panelBrand.Visible = false;
            panelProduct.Visible = false;
            panelCustomer.Visible = false;
            panelSupplier.Visible = false;

            var frmAdminList = new frmAdminList();
            frmAdminList.TopLevel = false;
            frmAdminList.AutoScroll = true;
            frmAdminList.FormBorderStyle = FormBorderStyle.None;
            panelUsers.Controls.Add(frmAdminList);

            frmAdminList.Show();
        }

        private void settingsTool_Click(object sender, EventArgs e)
        {
            usersToolStripMenuItem.BackColor = Color.SkyBlue;
            brandsTool.BackColor = Color.SkyBlue;
            categoryTool.BackColor = Color.SkyBlue;
            settingsTool.BackColor = Color.RoyalBlue;
            productToolStripMenuItem.BackColor = Color.SkyBlue;
            customersTool.BackColor = Color.SkyBlue;
            suppliersTool.BackColor = Color.SkyBlue;

            panelSettings.Visible = true;
            panelUsers.Visible = false;
            panelCategory.Visible = false;
            panelBrand.Visible = false;
            panelProduct.Visible = false;
            panelCustomer.Visible = false;
            panelSupplier.Visible = false;

            var frmSettings = new frmSettings(adminDto.Id, adminDto.UserName);
            frmSettings.TopLevel = false;
            frmSettings.AutoScroll = true;
            frmSettings.FormBorderStyle = FormBorderStyle.None;
            panelSettings.Controls.Add(frmSettings);

            frmSettings.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //panelUsers.Visible = false;
            //panelSettings.Visible = false;
            //panelMain.Visible = true;
            //label1.Visible = true;
        }

        private void categoryTool_Click(object sender, EventArgs e)
        {
            usersToolStripMenuItem.BackColor = Color.SkyBlue;
            brandsTool.BackColor = Color.SkyBlue;
            categoryTool.BackColor = Color.RoyalBlue;
            settingsTool.BackColor = Color.SkyBlue;
            productToolStripMenuItem.BackColor = Color.SkyBlue;
            customersTool.BackColor = Color.SkyBlue;
            suppliersTool.BackColor = Color.SkyBlue;

            panelCategory.Visible = true;
            panelUsers.Visible = false;
            panelSettings.Visible = false;
            panelBrand.Visible = false;
            panelProduct.Visible = false;
            panelCustomer.Visible = false;
            panelSupplier.Visible = false;

            var frmCategory = new frmCategory(adminDto.Id);
            frmCategory.TopLevel = false;
            frmCategory.AutoScroll = true;
            frmCategory.FormBorderStyle = FormBorderStyle.None;
            panelCategory.Controls.Add(frmCategory);

            frmCategory.Show();
        }

        private void brandsTool_Click(object sender, EventArgs e)
        {
            usersToolStripMenuItem.BackColor = Color.SkyBlue;
            brandsTool.BackColor = Color.RoyalBlue;
            categoryTool.BackColor = Color.SkyBlue;
            settingsTool.BackColor = Color.SkyBlue;
            productToolStripMenuItem.BackColor = Color.SkyBlue;
            customersTool.BackColor = Color.SkyBlue;
            suppliersTool.BackColor = Color.SkyBlue;

            panelBrand.Visible = true;
            panelCategory.Visible = false;
            panelUsers.Visible = false;
            panelSettings.Visible = false;
            panelProduct.Visible = false;
            panelCustomer.Visible = false;
            panelSupplier.Visible = false;

            var frmBrand = new frmBrands(adminDto.Id);
            frmBrand.TopLevel = false;
            frmBrand.AutoScroll = true;
            frmBrand.FormBorderStyle = FormBorderStyle.None;
            panelBrand.Controls.Add(frmBrand);

            frmBrand.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usersToolStripMenuItem.BackColor = Color.SkyBlue;
            brandsTool.BackColor = Color.SkyBlue;
            categoryTool.BackColor = Color.SkyBlue;
            settingsTool.BackColor = Color.SkyBlue;
            productToolStripMenuItem.BackColor = Color.RoyalBlue;
            customersTool.BackColor = Color.SkyBlue;
            suppliersTool.BackColor = Color.SkyBlue;

            panelProduct.Visible = true;
            panelBrand.Visible = false;
            panelCategory.Visible = false;
            panelUsers.Visible = false;
            panelSettings.Visible = false;
            panelCustomer.Visible = false;
            panelSupplier.Visible = false;

            var frmProduct = new frmProducts(adminDto.Id);
            frmProduct.TopLevel = false;
            frmProduct.AutoScroll = true;
            frmProduct.FormBorderStyle = FormBorderStyle.None;
            panelProduct.Controls.Add(frmProduct);

            frmProduct.Show();
        }

        private void customersTool_Click(object sender, EventArgs e)
        {
            usersToolStripMenuItem.BackColor = Color.SkyBlue;
            brandsTool.BackColor = Color.SkyBlue;
            categoryTool.BackColor = Color.SkyBlue;
            settingsTool.BackColor = Color.SkyBlue;
            productToolStripMenuItem.BackColor = Color.SkyBlue;
            customersTool.BackColor = Color.RoyalBlue;
            suppliersTool.BackColor = Color.SkyBlue;

            panelCustomer.Visible = true;
            panelProduct.Visible = false;
            panelBrand.Visible = false;
            panelCategory.Visible = false;
            panelUsers.Visible = false;
            panelSettings.Visible = false;
            panelSupplier.Visible = false;

            var frmCustomers = new frmCustomers(adminDto.Id);
            frmCustomers.TopLevel = false;
            frmCustomers.AutoScroll = true;
            frmCustomers.FormBorderStyle = FormBorderStyle.None;
            panelCustomer.Controls.Add(frmCustomers);

            frmCustomers.Show();
        }

        private void suppliersTool_Click(object sender, EventArgs e)
        {
            usersToolStripMenuItem.BackColor = Color.SkyBlue;
            brandsTool.BackColor = Color.SkyBlue;
            categoryTool.BackColor = Color.SkyBlue;
            settingsTool.BackColor = Color.SkyBlue;
            productToolStripMenuItem.BackColor = Color.SkyBlue;
            customersTool.BackColor = Color.SkyBlue;
            suppliersTool.BackColor = Color.RoyalBlue;

            panelSupplier.Visible = true;
            panelCustomer.Visible = false;
            panelProduct.Visible = false;
            panelBrand.Visible = false;
            panelCategory.Visible = false;
            panelUsers.Visible = false;
            panelSettings.Visible = false;

            var frmSuppliers = new frmSuppliers(adminDto.Id);
            frmSuppliers.TopLevel = false;
            frmSuppliers.AutoScroll = true;
            frmSuppliers.FormBorderStyle = FormBorderStyle.None;
            panelSupplier.Controls.Add(frmSuppliers);

            frmSuppliers.Show();
        }
    }
}
