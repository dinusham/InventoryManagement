using InventoryDataAccess;
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
    public partial class frmSettings : Form
    {
        private int adminId;

        public frmSettings(int adminId, string userName)
        {
            this.adminId = adminId;
            InitializeComponent();
            txtCurUser.Text = userName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCuPsw.Text) || string.IsNullOrEmpty(txtNwPsw.Text) ||
                string.IsNullOrEmpty(txtNwPsw2.Text))
            {
                MessageBox.Show("Values cannot be null");
            }
            else if (txtNwPsw.Text != txtNwPsw2.Text)
            {
                errorProvider.SetError(txtNwPsw2, "Passwords not match");
            }
            else
            {
                int status = InventoryLogin.UpdatePassword(adminId, txtNwPsw.Text);
                if (status > 0)
                {
                    MessageBox.Show("Successfully update");
                    txtCuPsw.Text = "";
                    txtNwPsw.Text = "";
                    txtNwPsw2.Text = "";
                }
            }
        }
    }
}
