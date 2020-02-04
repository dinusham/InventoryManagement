using AdminForms;
using CategoryForms;
using Brand;
using InventoryDataAccess;
using System;
using System.Windows.Forms;

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
            panelUsers.Visible = true;
            panelCategory.Visible = false;
            panelSettings.Visible = false;
            panelBrand.Visible = false;

            var frmAdminList = new frmAdminList();
            frmAdminList.TopLevel = false;
            frmAdminList.AutoScroll = true;
            frmAdminList.FormBorderStyle = FormBorderStyle.None;
            panelUsers.Controls.Add(frmAdminList);

            frmAdminList.Show();
        }

        private void settingsTool_Click(object sender, EventArgs e)
        {
            panelSettings.Visible = true;
            panelUsers.Visible = false;
            panelCategory.Visible = false;
            panelBrand.Visible = false;

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
            panelCategory.Visible = true;
            panelUsers.Visible = false;
            panelSettings.Visible = false;
            panelBrand.Visible = false;
            var frmCategory = new frmCategory(adminDto.Id);
            frmCategory.TopLevel = false;
            frmCategory.AutoScroll = true;
            frmCategory.FormBorderStyle = FormBorderStyle.None;
            panelCategory.Controls.Add(frmCategory);

            frmCategory.Show();
        }

        private void brandsTool_Click(object sender, EventArgs e)
        {
            panelBrand.Visible = true;
            panelCategory.Visible = false;
            panelUsers.Visible = false;
            panelSettings.Visible = false;

            var frmBrand = new frmBrands(adminDto.Id);
            frmBrand.TopLevel = false;
            frmBrand.AutoScroll = true;
            frmBrand.FormBorderStyle = FormBorderStyle.None;
            panelBrand.Controls.Add(frmBrand);

            frmBrand.Show();
        }
    }
}
