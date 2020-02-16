using InventoryDataAccess;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PurchaseItem
{
    public partial class frmPurchaseItems : Form
    {
        private Form frmPurchaseItem;
        private int orderId;
        private int userId;
        private DataTable orderItemTable;

        public frmPurchaseItems(Form frmPurchaseItem, int userId, int orderId, DataTable dataTable)
        {
            this.frmPurchaseItem = frmPurchaseItem;
            this.userId = userId;
            this.orderId = orderId;
            orderItemTable = dataTable;
            InitializeComponent();
        }

        public void frmPurchaseItems_Load(object sender, System.EventArgs e)
        {
            if (orderItemTable == null || orderItemTable.Rows.Count < 0)
            {
                orderItemTable = PurchaseOrderItemDataAccess.GetOrderItems(orderId);
            }
            orderItemTable = PurchaseOrderItemDataAccess.GetOrderItems(orderId);
            this.purchaseItemGridView.DataSource = orderItemTable;
            FormatGrid(ref this.purchaseItemGridView);
        }

        private void FormatGrid(ref DataGridView orderGridView)
        {
            for (int i = 0; i < orderGridView.Columns.Count; i++)
            {
                string colunmName = orderGridView.Columns[i].Name;
                switch (colunmName)
                {
                    case "id":
                    case "purchase_id":
                        orderGridView.Columns[i].Visible = false;
                        break;
                    case "Product":
                        orderGridView.Columns[i].Width = 125;
                        break;
                    case "Quantity":
                    case "Brand":
                        orderGridView.Columns[i].Width = 70;
                        break;
                    case "UnitPrice":
                        orderGridView.Columns[i].Width = 78;
                        orderGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "Total":
                        orderGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "CreatedBy":
                        orderGridView.Columns[i].Width = 80;
                        break;
                    //case "Title":
                    //    orderGridView.Columns[i].Width = 150;
                    //    break;
                    //case "category_id":
                    //    orderGridView.Columns[i].Visible = false;
                    //    break;
                    default:
                        break;
                }
            }

            foreach (DataGridViewRow row in orderGridView.Rows)
            {
                if (row.Index % 2 == 0)
                    row.DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmPurchaseItemAdd = new frmPurchaseItemAdd(this, userId, orderId, true);
            frmPurchaseItemAdd.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (purchaseItemGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow dataRow = purchaseItemGridView.SelectedRows[0];
                int.TryParse(dataRow.Cells["id"].Value.ToString(), out int id);
                if (id < 0)
                    return;

                var frmPurchaseItemAdd = new frmPurchaseItemAdd(this, userId, orderId, id);
                frmPurchaseItemAdd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an order to update");
            }
        }

        private void dataRowDouble_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dataRow = purchaseItemGridView.Rows[e.RowIndex];
            int.TryParse(dataRow.Cells["id"].Value.ToString(), out int id);
            if (id < 0)
                return;

            var frmPurchaseItemAdd = new frmPurchaseItemAdd(this, userId, orderId, id);
            frmPurchaseItemAdd.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
