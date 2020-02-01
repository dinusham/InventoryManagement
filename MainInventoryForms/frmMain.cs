using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainInventoryForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void addAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelUsers.Visible = true;
            //panelSettings.Visible = false;
            //panelMain.Visible = false;
            frmAdminList frmAdminList = new frmAdminList();
            frmAdminList.Show();
        }

        private void settingsTool_Click(object sender, EventArgs e)
        {
            //panelUsers.Visible = false;
            //panelSettings.Visible = true;
            //panelMain.Visible = false;
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
