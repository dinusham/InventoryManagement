using InventoryDataAccess;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Customer
{
    public partial class frmCustomerAdd : Form
    {
        private Form frmCustomer;
        private int customerId;
        private int userId;
        private CustomerDTO customer;

        public frmCustomerAdd(Form frmCustomer, int userId)
        {
            this.frmCustomer = frmCustomer;
            this.userId = userId;
            InitializeComponent();
        }

        public frmCustomerAdd(Form frmCustomer, int userId, int customerId)
        {
            this.frmCustomer = frmCustomer;
            this.userId = userId;
            this.customerId = customerId;
            InitializeComponent();
            ViewEditData();
        }

        private void ViewEditData()
        {
            customer = CustomerDataAccess.GetCustomerById(customerId);
            if (customer != null)
            {
                txtName.Text = customer.Name;
                txtEmail.Text = customer.Email;
                txtMobile.Text = customer.Mobile;
                chkActive.Checked = customer.IsActive;
            }
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtMobile.Text = "";
            chkActive.Checked = false;
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtMobile.Text) ||
                string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Values cannot be null");
                return;
            }
            else
            {
                Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                bool isValid = regex.IsMatch(txtEmail.Text.Trim());
                if (!isValid)
                {
                    MessageBox.Show("Invalid email");
                    return;
                }
            }
            int status = AddUpdateCustomer();
            if (status > 0)
            {
                if (customer != null && customer.Id > 0)
                    MessageBox.Show("Successfully updated");
                else
                    MessageBox.Show("Successfully added");
                txtName.Text = "";
                txtEmail.Text = "";
                txtMobile.Text = "";
                chkActive.Checked = false;
            }
            else
                MessageBox.Show("Customer didn't add or update");
        }

        private int AddUpdateCustomer()
        {
            if (customer != null && customer.Id > 0)
            {
                customer.Id = customer.Id;
                customer.Name = txtName.Text;
                customer.Mobile = txtMobile.Text;
                customer.Email = txtEmail.Text;
                customer.IsActive = chkActive.Checked;
                customer.UpdatedBy = userId;
                return CustomerDataAccess.UpdateCustomer(customer);
            }
            else
            {
                var customer = new CustomerDTO()
                {
                    Name = txtName.Text,
                    Email = txtEmail.Text,
                    Mobile = txtMobile.Text,
                    IsActive = chkActive.Checked,
                    CreatedBy = userId
                };
                return CustomerDataAccess.AddCustomer(customer);
            }
        }

        private void frmCustomerAdd_FormClosing(object sender, EventArgs e)
        {
            var parent = (frmCustomers)frmCustomer;
            parent.frmCustomers_Load(sender, e);
        }

        private void frmCustomerAdd_Load(object sender, EventArgs e)
        {
            if (customerId > 0)
                btnAdd.Text = "Update";
        }
    }
}
