using InventoryDataAccess;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PurchaseItem
{
    public partial class frmPurchaseItemAdd : Form
    {
        private Form frmPurchaseItem;
        private int purchaseId;
        private int itemId;
        private int userId;
        private PurchaseItemDTO purchaseItem;
        private IDictionary<int, string> products;
        private List<int> productsIds = new List<int>();
        private IDictionary<int, string> brands;
        private List<int> brandsIds = new List<int>();
        bool isRefresh;

        public frmPurchaseItemAdd(Form frmPurchaseItem, int userId, int purchaseId, bool isRefresh = false)
        {
            this.frmPurchaseItem = frmPurchaseItem;
            this.userId = userId;
            this.purchaseId = purchaseId;
            this.isRefresh = isRefresh;
            InitializeComponent();
            LoadComboBoxData();
        }

        public frmPurchaseItemAdd(Form frmPurchaseItem, int userId, int purchaseId, int itemId)
        {
            this.frmPurchaseItem = frmPurchaseItem;
            this.userId = userId;
            this.purchaseId = purchaseId;
            this.itemId = itemId;
            this.isRefresh = true;
            InitializeComponent();
            LoadComboBoxData();

            ViewPurchaseItemInfo();
        }

        private void ViewPurchaseItemInfo()
        {
            purchaseItem = PurchaseOrderItemDataAccess.GetPurchaseItemsById(itemId, purchaseId);
            if (purchaseItem != null)
            {
                cmbProduct.Text = products[purchaseItem.ProductId].ToString();
                cmbBrand.Text = brands[purchaseItem.BrandId].ToString();
                txtQuantity.Text = purchaseItem.Quntity.ToString();
                txtPrice.Text = string.Format("{0: 0.00}", purchaseItem.Price);
            }
        }

        private void LoadComboBoxData()
        {
            products = ProductDataAccess.GetProductsForPurchaseItem();
            if (products != null && cmbProduct.Items.Count < 1)
            {
                foreach (var item in products)
                {
                    cmbProduct.Items.Add(item.Value);
                    productsIds.Add(item.Key);
                }
            }
            brands = BrandDataAccess.GetBrandsForPurchaseItem();
            if (brands != null && cmbBrand.Items.Count < 1)
            {
                foreach (var item in brands)
                {
                    cmbBrand.Items.Add(item.Value);
                    brandsIds.Add(item.Key);
                }
            }
        }

        private void frmPurchaseItemAdd_Load(object sender, EventArgs e)
        {
            if (itemId > 0)
                btnAdd.Text = "Update";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuantity.Text) || string.IsNullOrEmpty(txtPrice.Text) ||
                txtPrice.Text == "0.00" || cmbProduct.SelectedIndex == -1 || cmbBrand.SelectedIndex == -1)
            {
                MessageBox.Show("Values cannot be null");
                return;
            }
            int status = AddUpdatePurchaseItem();
            if (status > 0)
            {
                if (purchaseItem != null && purchaseItem.Id > 0)
                    MessageBox.Show("Successfully updated");
                else
                    MessageBox.Show("Successfully added");

                cmbBrand.SelectedIndex = -1;
                cmbProduct.SelectedIndex = -1;
                txtPrice.Text = "0.00";
                txtQuantity.Text = "";
            }
            else
                MessageBox.Show("Purchase item didn't add or update");
        }

        private int AddUpdatePurchaseItem()
        {
            if (purchaseItem != null && purchaseItem.Id > 0 && purchaseItem.PurchaseId > 0)
            {
                purchaseItem.ProductId = cmbProduct.SelectedIndex + 1;
                purchaseItem.BrandId = cmbBrand.SelectedIndex + 1;
                purchaseItem.Quntity = int.Parse(txtQuantity.Text);
                purchaseItem.Price = Convert.ToDecimal(txtPrice.Text);
                purchaseItem.UpdatedBy = userId;
                return PurchaseOrderItemDataAccess.UpdateOrderItems(purchaseItem);
            }
            else
            {
                var purchaseItem = new PurchaseItemDTO
                {
                    PurchaseId = purchaseId,
                    ProductId = cmbProduct.SelectedIndex + 1,
                    BrandId = cmbBrand.SelectedIndex + 1,
                    Quntity = int.Parse(txtQuantity.Text),
                    Price = Convert.ToDecimal(txtPrice.Text),
                    CreatedBy = userId
                };
                return PurchaseOrderItemDataAccess.AddOrderItems(purchaseItem);
            }
        }

        private void txtQuntity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void frmPurchaseItemAdd_Closing(object sender, EventArgs e)
        {
            if (isRefresh)
            {
                var parent = (frmPurchaseItems)frmPurchaseItem;
                parent.frmPurchaseItems_Load(sender, e);
            }
        }
    }
}
