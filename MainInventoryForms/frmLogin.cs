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
                (bool valid, AdminDTO adminDto) = ValidateLoginUser();
                if (valid)
                {
                    frmMain mainFrm = new frmMain(adminDto);
                    //var mainFrm = new Form1Test();
                    this.Hide();
                    mainFrm.ShowDialog();
                    this.Close();
                }
            }
        }

        private (bool, AdminDTO) ValidateLoginUser()
        {
            var adminDto = InventoryLogin.IsValidLogin(loginUserName.Text, loginPassword.Text);

            if (adminDto != null)
            {
                if (!adminDto.IsActive)
                    MessageBox.Show("Inactive user");
                else
                    return (true, adminDto);
            }
            else
                MessageBox.Show("Incorrect userName or password");
            return (false, null);
        }
    }
}
