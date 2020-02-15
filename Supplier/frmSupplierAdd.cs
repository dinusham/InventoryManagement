using InventoryDataAccess;
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
    }
}
