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
    public partial class frmAdminAdd : Form
    {
        private Form frmAdminList;
        private AdminDTO userDto;
        private int adminId;

        public frmAdminAdd(Form frmAdminList)
        {
            this.frmAdminList = frmAdminList;
            InitializeComponent();
        }

        public frmAdminAdd(Form frmAdminList, int adminId)
        {
            this.frmAdminList = frmAdminList;
            this.adminId = adminId;
            InitializeComponent();
            ViewEditdata(adminId);
        }

        private void ViewEditdata(int adminId)
        {
            var adminDto = Admin.GetAdminInfoById(adminId);
            if (adminDto != null)
            {
                textBoxFName.Text = adminDto.FirstName;
                textBoxLName.Text = adminDto.LastName;
                textBoxEmail.Text = adminDto.Email;
                textBoxMobile.Text = adminDto.Mobile;
                textBoxUName.Text = adminDto.UserName;
                textBoxPsw.Text = adminDto.Password;
            }
            return;
        }

        private void ViewEditdata(AdminDTO adminDto)
        {
            textBoxFName.Text = adminDto.FirstName;
            textBoxLName.Text = adminDto.LastName;
            textBoxEmail.Text = adminDto.Email;
            textBoxMobile.Text = adminDto.Mobile;
            textBoxUName.Text = adminDto.UserName;
            textBoxPsw.Text = adminDto.Password;
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
                MessageBox.Show("Successfully added");
                ClearDataFields();
            }
        }

        private int AddUpdateAdmin()
        {
            if (userDto != null && userDto.Id > 0)
            {
                GetInputValues(ref userDto);
                return Admin.UpdateAdmin(userDto);
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
