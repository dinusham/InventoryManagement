using System;
using System.Windows.Forms;

namespace MainInventoryForms
{
    public partial class frmMain : Form
    {
        private bool isAdmin;

        public frmMain(bool isAdmin)
        {
            this.isAdmin = isAdmin;
            InitializeComponent();
            ManageComponents();
        }

        private void ManageComponents()
        {
            if (!isAdmin)
                usersToolStripMenuItem.Visible = false;
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelUsers.Visible = true;
            var frmAdminList = new frmAdminList();
            frmAdminList.TopLevel = false;
            frmAdminList.AutoScroll = true;
            frmAdminList.FormBorderStyle = FormBorderStyle.None;
            panelUsers.Controls.Add(frmAdminList);

            frmAdminList.Show();
        }

        private void settingsTool_Click(object sender, EventArgs e)
        {
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            panelUsers.Visible = false;
            //panelSettings.Visible = false;
            //panelMain.Visible = true;
            //label1.Visible = true;
        }
    }
}
