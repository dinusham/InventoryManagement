using InventoryDataAccess;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Product
{
    public partial class frmProductAdd : Form
    {
        private Form frmProduct;
        private int productId;
        private int userId;
        private ProductDTO product;
        private IDictionary<int, string> keyValues;
        private List<int> categoryIds = new List<int>();

        public frmProductAdd(Form frmProduct, int userId)
        {
            this.frmProduct = frmProduct;
            this.userId = userId;
            InitializeComponent();
            chkActive.Visible = false;
        }

        public frmProductAdd(Form frmProduct, int userId, int productId)
        {
            this.frmProduct = frmProduct;
            this.userId = userId;
            this.productId = productId;
            InitializeComponent();

            keyValues = CategoryDataAccess.GetCategoriesForProduct();
            if (keyValues != null)
            {
                foreach (var item in keyValues)
                {
                    cmbCategory.Items.Add(item.Value);
                    categoryIds.Add(item.Key);
                }
            }

            ViewEditData();
        }

        private void ViewEditData()
        {
            product = ProductDataAccess.GetProductById(productId);
            if (product != null)
            {
                txtName.Text = product.ProductName;
                txtCode.Text = product.ProductCode;
                txtTitle.Text = product.ProductTitle;
                cmbCategory.Text = keyValues[product.CategoryId].ToString();
                chkActive.Checked = product.IsActive;
            }
        }

        private void frmProductAdd_Load(object sender, EventArgs e)
        {
            keyValues = CategoryDataAccess.GetCategoriesForProduct();
            if (keyValues != null)
            {
                foreach (var item in keyValues)
                {
                    cmbCategory.Items.Add(item.Value);
                    categoryIds.Add(item.Key);
                }
            }
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtCode.Text) ||
                string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(cmbCategory.Text))
            {
                MessageBox.Show("Values cannot be null");
                return;
            }
            int status = AddUpdateProduct();
            if (status > 0)
            {
                if (product != null && product.Id > 0)
                    MessageBox.Show("Successfully updated");
                else
                    MessageBox.Show("Successfully added");
                txtName.Text = "";
                txtCode.Text = "";
                txtTitle.Text = "";
                cmbCategory.SelectedIndex = -1;
                chkActive.Checked = false;
            }
            else
                MessageBox.Show("Product didn't add or update");
        }

        private int AddUpdateProduct()
        {
            if (product != null && product.Id > 0)
            {
                product.Id = productId;
                product.ProductName = txtName.Text;
                product.ProductCode = txtCode.Text;
                product.ProductTitle = txtTitle.Text;
                product.CategoryId = categoryIds[cmbCategory.SelectedIndex];
                product.IsActive = chkActive.Checked;
                product.UpdatedBy = userId;
                return ProductDataAccess.UpdateProduct(product);
            }
            else
            {
                var product = new ProductDTO()
                {
                    ProductName = txtName.Text,
                    ProductCode = txtCode.Text,
                    ProductTitle = txtTitle.Text,
                    CategoryId = categoryIds[cmbCategory.SelectedIndex],
                    CreatedBy = userId
                };
                return ProductDataAccess.AddProduct(product);
            }
        }

        private void frmProductAdd_FormClosing(object sender, EventArgs e)
        {
            var parent = (frmProducts)frmProduct;
            parent.frmProduct_Load(sender, e);
        }
    }
}
