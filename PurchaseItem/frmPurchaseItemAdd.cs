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

namespace PurchaseItem
{
    public partial class frmPurchaseItemAdd : Form
    {
        private Form frmPurchaseItem;
        private int orderId;
        private int userId;
        private PurchaseItemsDTO purchaseItem;
        private IDictionary<int, string> products;
        private List<int> productsIds = new List<int>();

        public frmPurchaseItemAdd(Form frmPurchaseItem, int userId, int orderId)
        {
            this.frmPurchaseItem = frmPurchaseItem;
            this.userId = userId;
            this.orderId = orderId;
            InitializeComponent();
        }

        private void frmPurchaseItemAdd_Load(object sender, EventArgs e)
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


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
