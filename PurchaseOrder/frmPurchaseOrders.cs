using InventoryDataAccess;
using PurchaseItem;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static Common.OrderInfo;

namespace PurchaseOrder
{
    public partial class frmPurchaseOrders : Form
    {
        private int userId;

        public frmPurchaseOrders(int userId)
        {
            this.userId = userId;
            InitializeComponent();
        }

        public void frmPurchaseOrders_Load(object sender, EventArgs e)
        {
            DataTable dt = PurchaseOrderDataAccess.GetOrders();
            if (dt != null)
            {
                this.orderGridView.DataSource = dt;
                FormatGrid(ref this.orderGridView);
            }
            if (cmbPaidStatus.Items.Count < 1)
            {
                var payTypes = Enum.GetValues(typeof(PayType));
                cmbPaidStatus.Items.Add("All");
                foreach (var item in payTypes)
                {
                    cmbPaidStatus.Items.Add(item.ToString());
                }
            }
        }

        private void FormatGrid(ref DataGridView orderGridView)
        {
            for (int i = 0; i < orderGridView.Columns.Count; i++)
            {
                string colunmName = orderGridView.Columns[i].Name;
                switch (colunmName)
                {
                    case "id":
                        orderGridView.Columns[i].Visible = false;
                        break;
                    case "Price":
                    case "Total":
                    case "DiscountPrice":
                        orderGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "Discount":
                        orderGridView.Columns[i].Width = 70;
                        orderGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "PayType":
                        orderGridView.Columns[i].Width = 100;
                        break;
                    case "category_id":
                        orderGridView.Columns[i].Visible = false;
                        break;
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
            var frmPurchaseOrderAdd = new frmPurchaseOrderAdd(this, userId);
            frmPurchaseOrderAdd.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (orderGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow dataRow = orderGridView.SelectedRows[0];
                int.TryParse(dataRow.Cells["id"].Value.ToString(), out int id);
                if (id < 0)
                    return;

                var frmPurchaseOrderAdd = new frmPurchaseOrderAdd(this, userId, id);
                frmPurchaseOrderAdd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an order to update");
            }
        }

        private void dataRowDouble_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dataRow = orderGridView.Rows[e.RowIndex];
            int.TryParse(dataRow.Cells["id"].Value.ToString(), out int id);
            if (id < 0)
                return;

            var frmPurchaseOrderAdd = new frmPurchaseOrderAdd(this, userId, id);
            frmPurchaseOrderAdd.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTxt = txtSearch.Text;
            if (string.IsNullOrEmpty(searchTxt))
            {
                frmPurchaseOrders_Load(sender, e);
            }
            else if (searchTxt.Length < 3)
            {
                MessageBox.Show("Please enter minimum 3 characters");
                txtSearch.Text = "";
                return;
            }

            if (orderGridView != null)
            {
                (orderGridView.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("Description LIKE '%{0}%' OR PaidDate = '{0}'", searchTxt);
            }
            txtSearch.Text = "";
        }

        private void cmbPaidStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaidStatus.SelectedIndex == 0)
            {
                (orderGridView.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("id > {0}", 0);
            }
            else
            {
                int statusId = cmbPaidStatus.SelectedIndex;
                (orderGridView.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("PayType = '{0}'", ((PayType)statusId).ToString());
            }
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            if (orderGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow dataRow = orderGridView.SelectedRows[0];
                int.TryParse(dataRow.Cells["id"].Value.ToString(), out int id);
                if (id < 0)
                    return;

                var frmPurchaseItemAdd = new frmPurchaseItemAdd(this, userId, id);
                frmPurchaseItemAdd.ShowDialog();
            }
            else
                MessageBox.Show("Please select an order to add items");
        }

        private void btnViewItems_Click(object sender, EventArgs e)
        {
            if (orderGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow dataRow = orderGridView.SelectedRows[0];
                int.TryParse(dataRow.Cells["id"].Value.ToString(), out int id);
                if (id < 0)
                    return;

                DataTable dt = PurchaseOrderItemDataAccess.GetOrderItems(id);
                if (dt != null && dt.Rows.Count > 0)
                {
                    var frmPurchaseItems = new frmPurchaseItems(this, userId, id, dt);
                    frmPurchaseItems.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Order doesn't have any item to view");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select an order to view items");
            }
        }
    }
}
