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
    public partial class frmUserAdd : Form
    {
        private Form frmAdminList;
        private UserDTO userDto;

        public frmUserAdd(Form frmAdminList)
        {
            this.frmAdminList = frmAdminList;
            InitializeComponent();
        }

        public frmUserAdd(Form frmAdminList, UserDTO userDto)
        {
            this.frmAdminList = frmAdminList;
            this.userDto = userDto;
            InitializeComponent();
            ViewEditdata(userDto);
        }

        private void ViewEditdata(UserDTO userDto)
        {
            textBoxFName.Text = userDto.FirstName;
            textBoxLName.Text = userDto.LastName;
            textBoxEmail.Text = userDto.Email;
            textBoxMobile.Text = userDto.Mobile;
            textBoxUName.Text = userDto.UserName;
            textBoxPsw.Text = userDto.Password;
        }

        private void btnUseradd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFName.Text) || string.IsNullOrEmpty(textBoxLName.Text) ||
                //string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxMobile.Text) ||
                string.IsNullOrEmpty(textBoxUName.Text) || string.IsNullOrEmpty(textBoxPsw.Text))
            {
                MessageBox.Show("Values cannot be null");
                return;
            }

            int success = AddUpdateUser();
            
            if (success > 0)
            {
                MessageBox.Show("Successfully added");
                ClearUserAddForm();
            }
        }

        private int AddUpdateUser()
        {
            if (userDto != null && userDto.Id > 0)
            {
                GetInputValues(ref userDto);
                return Admin.UpdateUser(userDto);
            }
            else
            {
                var user = new UserDTO();
                GetInputValues(ref user);
                return Admin.AddUser(user);
            }
        }

        private void GetInputValues(ref UserDTO userDto)
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
            ClearUserAddForm();
        }

        private void ClearUserAddForm()
        {
            textBoxFName.Text = "";
            textBoxLName.Text = "";
            textBoxEmail.Text = "";
            textBoxMobile.Text = "";
            textBoxUName.Text = "";
            textBoxPsw.Text = "";
        }

        private void frmUserAdd_FormClosing(object sender, EventArgs e)
        {
            var parent = (frmAdminList)frmAdminList;
            parent.frmAdminList_Load(sender, e);
        }
    }
}
