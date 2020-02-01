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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void loginCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loginUserName.Text) || string.IsNullOrEmpty(loginPassword.Text))
            {
                MessageBox.Show("Cannot be empty userName or password");
            }
            else if (loginUserName.Text == "aaa" && loginPassword.Text == "aaa")
            {
                //frmLogin frmLogin = new frmLogin();
                frmMain mainFrm = new frmMain();
                this.Hide();
                mainFrm.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Incorrect userName or password");

        }
    }
}
