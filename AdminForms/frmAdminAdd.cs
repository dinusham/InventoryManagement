﻿using InventoryDataAccess;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AdminForms
{
    public partial class frmAdminAdd : Form
    {
        private Form frmAdminList;
        private AdminDTO adminDto;
        private int userId;

        public frmAdminAdd(Form frmAdminList, int userId)
        {
            this.userId = userId;
            this.frmAdminList = frmAdminList;
            InitializeComponent();
        }

        public frmAdminAdd(Form frmAdminList, int userId, int adminId)
        {
            this.userId = userId;
            this.frmAdminList = frmAdminList;
            InitializeComponent();
            btnAdminadd.Name = "Update";
            ViewEditdata(adminId);
        }

        private void ViewEditdata(int adminId)
        {
            var adminDto = AdminDataAccess.GetAdminInfoById(adminId);
            if (adminDto != null)
            {
                this.adminDto = adminDto;
                textBoxFName.Text = adminDto.FirstName;
                textBoxLName.Text = adminDto.LastName;
                textBoxEmail.Text = adminDto.Email;
                textBoxMobile.Text = adminDto.Mobile;
                textBoxUName.Text = adminDto.UserName;
            }
            return;
        }

        private void btnAdminadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFName.Text) || string.IsNullOrEmpty(textBoxLName.Text) ||
                //string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxMobile.Text) ||
                string.IsNullOrEmpty(textBoxUName.Text) || string.IsNullOrEmpty(textBoxPsw.Text) || string.IsNullOrEmpty(textBoxPswRe.Text))
            {
                MessageBox.Show("Values cannot be null");
                return;
            }
            else if (!string.IsNullOrEmpty(textBoxEmail.Text))
            {
                Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                bool isValid = regex.IsMatch(textBoxEmail.Text.Trim());
                if(!isValid)
                {
                    MessageBox.Show("Invalid email");
                    return;
                }
            }
            else if (string.IsNullOrEmpty(textBoxPsw.Text) != string.IsNullOrEmpty(textBoxPswRe.Text))
            {
                errorProvider.SetError(textBoxPswRe, "Passwords not match");
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
                adminDto.UpdatedBy = userId;
                return AdminDataAccess.UpdateAdmin(adminDto);
            }
            else
            {
                var adminDto = new AdminDTO()
                {
                    CreatedBy = userId
                };
                GetInputValues(ref adminDto);
                return AdminDataAccess.AddAdmin(adminDto);
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
            textBoxPswRe.Text = "";
        }

        private void frmAdminAdd_FormClosing(object sender, EventArgs e)
        {
            var parent = (frmAdminList)frmAdminList;
            parent.frmAdminList_Load(sender, e);
        }

        private void frmAdminAdd_Load(object sender, EventArgs e)
        {
            if (userId > 0)
                btnAdminadd.Text = "Update";
        }
    }
}
