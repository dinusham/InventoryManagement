using InventoryDataAccess;
using System;
using System.Windows.Forms;

namespace Brand
{
    public partial class frmBrandAdd : Form
    {
        private Form frmBrand;
        private int brandId;
        private int userId;
        private BrandDTO brand;

        public frmBrandAdd(Form frmBrand, int userId)
        {
            this.frmBrand = frmBrand;
            this.userId = userId;
            InitializeComponent();
        }

        public frmBrandAdd(Form frmBrand, int userId, int brandId)
        {
            this.frmBrand = frmBrand;
            this.userId = userId;
            this.brandId = brandId;
            InitializeComponent();
            ViewEditData();
        }

        private void ViewEditData()
        {
            brand = BrandDataAccess.GetBrandById(brandId);
            if (brand != null)
            {
                txtBrand.Text = brand.BrandName;
                chkActive.Checked = brand.IsActive;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBrand.Text))
            {
                MessageBox.Show("Values cannot be null");
                return;
            }
            int status = AddUpdateBrand();
            if (status > 0)
            {
                if (brand != null && brand.Id > 0)
                    MessageBox.Show("Successfully updated");
                else
                    MessageBox.Show("Successfully added");
                txtBrand.Text = "";
                chkActive.Checked = false;
            }
            else
                MessageBox.Show("Brand didn't add or update");
        }

        private int AddUpdateBrand()
        {
            if (brand != null && brand.Id > 0)
            {
                brand.Id = brandId;
                brand.BrandName = txtBrand.Text;
                brand.IsActive = chkActive.Checked;
                brand.UpdatedBy = userId;
                return BrandDataAccess.UpdateBrand(brand);
            }
            else
            {
                var brand = new BrandDTO()
                {
                    BrandName = txtBrand.Text,
                    IsActive = chkActive.Checked,
                    CreatedBy = userId
                };
                return BrandDataAccess.AddBrand(brand);
            }
        }

        private void frmBrandAdd_FormClosing(object sender, EventArgs e)
        {
            var parent = (frmBrands)frmBrand;
            parent.frmBrands_Load(sender, e);
        }
    }
}
