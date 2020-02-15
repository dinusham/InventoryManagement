using InventoryDataAccess;
using System;
using System.Windows.Forms;

namespace Supplier
{
    public partial class frmSupplierAdd : Form
    {
        private Form frmSupplier;
        private int supplierId;
        private int userId;
        private SupplierDTO supplier;

        public frmSupplierAdd(Form frmSupplier, int userId)
        {
            this.frmSupplier = frmSupplier;
            this.userId = userId;
            InitializeComponent();
        }

        public frmSupplierAdd(Form frmSupplier, int userId, int supplierId)
        {
            this.frmSupplier = frmSupplier;
            this.userId = userId;
            this.supplierId = supplierId;
            InitializeComponent();
            btnAdd.Text = "Update";
            ViewEditData();
        }

        private void ViewEditData()
        {
            supplier = SupplierDataAccess.GetSupplierById(supplierId);
            if (supplier != null)
            {
                txtName.Text = supplier.Name;
                txtEmail.Text = supplier.Email;
                txtMobile.Text = supplier.Mobile;
                chkActive.Checked = supplier.IsActive;
            }
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtMobile.Text) ||
                string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Values cannot be null");
                return;
            }
            int status = AddUpdateSupplier();
            if (status > 0)
            {
                if (supplier != null && supplier.Id > 0)
                    MessageBox.Show("Successfully updated");
                else
                    MessageBox.Show("Successfully added");
                txtName.Text = "";
                txtEmail.Text = "";
                txtMobile.Text = "";
                chkActive.Checked = false;
            }
            else
                MessageBox.Show("Supplier didn't add or update");
        }

        private int AddUpdateSupplier()
        {
            if (supplier != null && supplier.Id > 0)
            {
                supplier.Id = supplier.Id;
                supplier.Name = txtName.Text;
                supplier.Mobile = txtMobile.Text;
                supplier.Email = txtEmail.Text;
                supplier.IsActive = chkActive.Checked;
                supplier.UpdatedBy = userId;
                return SupplierDataAccess.UpdateSupplier(supplier);
            }
            else
            {
                var supplierDto = new SupplierDTO()
                {
                    Name = txtName.Text,
                    Email = txtEmail.Text,
                    Mobile = txtMobile.Text,
                    IsActive = chkActive.Checked,
                    CreatedBy = userId
                };
                return SupplierDataAccess.AddSupplier(supplierDto);
            }
        }

        private void frmSupplierAdd_FormClosing(object sender, EventArgs e)
        {
            var parent = (frmSuppliers)frmSupplier;
            parent.frmSuppliers_Load(sender, e);
        }
    }
}
