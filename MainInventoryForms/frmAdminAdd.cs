using InventoryDataAccess;
using System;
using System.Windows.Forms;

namespace MainInventoryForms
{
    public partial class frmAdminAdd : Form
    {
        private Form frmAdminList;
        private AdminDTO adminDto;

        public frmAdminAdd(Form frmAdminList)
        {
            this.frmAdminList = frmAdminList;
            InitializeComponent();
        }

        public frmAdminAdd(Form frmAdminList, int adminId)
        {
            this.frmAdminList = frmAdminList;
            InitializeComponent();
            ViewEditdata(adminId);
        }

        private void ViewEditdata(int adminId)
        {
            var adminDto = Admin.GetAdminInfoById(adminId);
            if (adminDto != null)
            {
                this.adminDto = adminDto;
                textBoxFName.Text = adminDto.FirstName;
                textBoxLName.Text = adminDto.LastName;
                textBoxEmail.Text = adminDto.Email;
                textBoxMobile.Text = adminDto.Mobile;
                textBoxUName.Text = adminDto.UserName;
                textBoxPsw.Text = adminDto.Password;
            }
            return;
        }

        private void btnAdminadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFName.Text) || string.IsNullOrEmpty(textBoxLName.Text) ||
                //string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxMobile.Text) ||
                string.IsNullOrEmpty(textBoxUName.Text) || string.IsNullOrEmpty(textBoxPsw.Text))
            {
                MessageBox.Show("Values cannot be null");
                return;
            }

            int success = AddUpdateAdmin();
            
            if (success > 0)
            {
                if (adminDto != null && adminDto.Id > 0)
                    MessageBox.Show("Successfully updated");
                else
                    MessageBox.Show("Successfully added");
                ClearDataFields();
            }
        }

        private int AddUpdateAdmin()
        {
            if (adminDto != null && adminDto.Id > 0)
            {
                GetInputValues(ref adminDto);
                return Admin.UpdateAdmin(adminDto);
            }
            else
            {
                var user = new AdminDTO();
                GetInputValues(ref user);
                return Admin.AddAdmin(user);
            }
        }

        private void GetInputValues(ref AdminDTO userDto)
        {
            userDto.FirstName = textBoxFName.Text;
            userDto.LastName = textBoxLName.Text;
            userDto.Email = textBoxEmail.Text;
            userDto.Mobile = textBoxMobile.Text;
            userDto.UserName = textBoxUName.Text;
            userDto.Password = textBoxPsw.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDataFields();
        }

        private void ClearDataFields()
        {
            textBoxFName.Text = "";
            textBoxLName.Text = "";
            textBoxEmail.Text = "";
            textBoxMobile.Text = "";
            textBoxUName.Text = "";
            textBoxPsw.Text = "";
        }

        private void frmAdminAdd_FormClosing(object sender, EventArgs e)
        {
            var parent = (frmAdminList)frmAdminList;
            parent.frmAdminList_Load(sender, e);
        }
    }
}
