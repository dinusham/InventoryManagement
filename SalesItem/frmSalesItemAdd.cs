using InventoryDataAccess;
using InventoryDataAccess.DataDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SalesItem
{
    public partial class frmSalesItemAdd : Form
    {
        private Form frmSalesItem;
        private int salesId;
        private int itemId;
        private int userId;
        private SalesItemDTO salesItem;
        private List<int> productsIds = new List<int>();
        private List<int> productItems = new List<int>();
        private List<AvailableProductsDTO> availableProducts;
        bool isRefresh;

        public frmSalesItemAdd(Form frmSalesItem, int userId, int salesId, bool isRefresh = false)
        {
            this.frmSalesItem = frmSalesItem;
            this.userId = userId;
            this.salesId = salesId;
            this.isRefresh = isRefresh;
            InitializeComponent();
            LoadComboBoxData();
        }

        public frmSalesItemAdd(Form frmSalesItem, int userId, int salesId, int itemId)
        {
            this.frmSalesItem = frmSalesItem;
            this.userId = userId;
            this.salesId = salesId;
            this.itemId = itemId;
            this.isRefresh = true;
            InitializeComponent();
            LoadComboBoxData(true);

            ViewSalesItemInfo();
        }

        private void ViewSalesItemInfo()
        {
            salesItem = SalesOrderItemDataAccess.GetSalesItemsById(itemId, salesId);
            if (salesItem != null)
            {
                cmbProduct.SelectedIndex = productsIds.FindIndex(x => x == salesItem.ProductId);
                //cmbSalesItem.Text = brands[salesItem.BrandId].ToString();
                //cmbOrderItem.Text = brands[salesItem.PurchaseHItemId].ToString();
                //cmbSalesItem.Text = salesItem.Brand + " | Price - " + salesItem.UnitPrice + " Avalilable - " + item.AvailableItemCounts;
                txtQuantity.Text = salesItem.Quntity.ToString();
                txtSUnitPrice.Text = string.Format("{0: 0.00}", salesItem.Price);
            }
        }

        private void frmSalesItemAdd_Load(object sender, EventArgs e)
        {
            if (itemId > 0)
                btnAdd.Text = "Update";
        }

        private void LoadComboBoxData(bool IsAddAllItems = false)
        {
            availableProducts = ProductDataAccess.GetProductsForSalesItem(IsAddAllItems);
            if (availableProducts != null && cmbProduct.Items.Count < 1)
            {
                foreach (var item in availableProducts)
                {
                    cmbProduct.Items.Add(item.Product);
                    productsIds.Add(item.Id);
                }
            }
            //saleItems = SalesOrderDataAccess.GetProductItemsForSales();
            //if (brands != null && cmbSalesItem.Items.Count < 1)
            //{
            //    foreach (var item in brands)
            //    {
            //        cmbSalesItem.Items.Add(item.Value);
            //        brandsIds.Add(item.Key);
            //    }
            //}
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuantity.Text) || string.IsNullOrEmpty(txtSUnitPrice.Text) ||
                cmbProduct.SelectedIndex == -1 || cmbSalesItem.SelectedIndex == -1)
            {
                MessageBox.Show("Values cannot be null");
                return;
            }
            int status = AddUpdateSalesItem();
            if (status > 0)
            {
                if (salesItem != null && salesItem.Id > 0)
                    MessageBox.Show("Successfully updated");
                else
                    MessageBox.Show("Successfully added");

                cmbSalesItem.SelectedIndex = -1;
                cmbProduct.SelectedIndex = -1;
                txtSUnitPrice.Text = "0.00";
                txtQuantity.Text = "";
            }
            else
                MessageBox.Show("Purchase item didn't add or update");
        }

        private int AddUpdateSalesItem()
        {
            if (salesItem != null && salesItem.Id > 0 && salesItem.SalesId > 0)
            {
                salesItem.ProductId = cmbProduct.SelectedIndex + 1;
                salesItem.BrandId = cmbSalesItem.SelectedIndex + 1;
                salesItem.Quntity = int.Parse(txtQuantity.Text);
                salesItem.Price = Convert.ToDecimal(txtSUnitPrice.Text);
                salesItem.UpdatedBy = userId;
                return SalesOrderItemDataAccess.UpdateSalesItems(salesItem);
            }
            else
            {
                var salesItem = new SalesItemDTO
                {
                    SalesId = salesId,
                    ProductId = cmbProduct.SelectedIndex + 1,
                    BrandId = cmbSalesItem.SelectedIndex + 1,
                    //PurchaseHItemId = cmbOrderItem.SelectedIndex + 1,
                    Quntity = int.Parse(txtQuantity.Text),
                    Price = Convert.ToDecimal(txtSUnitPrice.Text),
                    CreatedBy = userId
                };
                return SalesOrderItemDataAccess.AddSalesItems(salesItem);
            }
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int productId = cmbProduct.SelectedIndex+1;
            var productItemStock = SalesOrderItemDataAccess.GetProductItemsForSales(productId);

            cmbSalesItem.Items.Clear();
            if (productItemStock != null && productItemStock.Any())
            {
                foreach (var item in productItemStock)
                {
                    cmbSalesItem.Items.Add(item.Brand + " | Price - " + item.UnitPrice + " Avalilable - " + item.AvailableItemCount);

                }
            }
        }
    }
}
