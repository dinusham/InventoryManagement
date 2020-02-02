using InventoryDataAccess;
using System;
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
            else
            {
                (bool valid, bool isAdmin) = ValidateLoginUser();
                if (valid)
                {
                    frmMain mainFrm = new frmMain(isAdmin);
                    this.Hide();
                    mainFrm.ShowDialog();
                    this.Close();
                }
            }
        }

        private (bool, bool) ValidateLoginUser()
        {
            (bool valid, bool isAdmin, bool isActive) = InventoryLogin.IsValidLogin(loginUserName.Text, loginPassword.Text);

            if (valid)
            {
                if (!isActive)
                    MessageBox.Show("Inactive user");
                else
                    return (true, isAdmin);
            }
            else
                MessageBox.Show("Incorrect userName or password");
            return (false, false);
        }
    }
}
