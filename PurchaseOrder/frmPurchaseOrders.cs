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
using static PurchaseOrder.PurchaseOrderInfo;

namespace PurchaseOrder
{
    public partial class frmPurchaseOrders : Form
    {
        private int userId;
        private IDictionary<int, string> keyValues;

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
                    case "Name":
                        orderGridView.Columns[i].Width = 140;
                        break;
                    case "Status":
                        orderGridView.Columns[i].Width = 90;
                        break;
                    case "Title":
                        orderGridView.Columns[i].Width = 150;
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
                MessageBox.Show("Please select a brand to update");
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
    }
}
