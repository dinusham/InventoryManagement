using InventoryDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static Common.OrderInfo;

namespace SalesOrder
{
    public partial class frmSalesOrders : Form
    {
        private int userId;
        private IDictionary<int, string> keyValues;

        public frmSalesOrders(int userId)
        {
            this.userId = userId;
            InitializeComponent();
        }

        public void frmSalesOrders_Load(object sender, EventArgs e)
        {
            DataTable dt = SalesOrderDataAccess.GetSalesOrders();
            if (dt != null)
            {
                this.salesOrderGridView.DataSource = dt;
                FormatGrid(ref this.salesOrderGridView);
            }
            if (cmbPayType.Items.Count < 1)
            {
                var payTypes = Enum.GetValues(typeof(PayType));
                cmbPayType.Items.Add("All");
                foreach (var item in payTypes)
                {
                    cmbPayType.Items.Add(item.ToString());
                }
            }
        }

        private void FormatGrid(ref DataGridView salesOrderGridView)
        {
            for (int i = 0; i < salesOrderGridView.Columns.Count; i++)
            {
                string colunmName = salesOrderGridView.Columns[i].Name;
                switch (colunmName)
                {
                    case "id":
                        salesOrderGridView.Columns[i].Visible = false;
                        break;
                    case "Price":
                    case "Total":
                    case "DiscountPrice":
                        salesOrderGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "Discount":
                        salesOrderGridView.Columns[i].Width = 70;
                        salesOrderGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "PayType":
                        salesOrderGridView.Columns[i].Width = 100;
                        break;
                    case "category_id":
                        salesOrderGridView.Columns[i].Visible = false;
                        break;
                    default:
                        break;
                }
            }

            foreach (DataGridViewRow row in salesOrderGridView.Rows)
            {
                if (row.Index % 2 == 0)
                    row.DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        private void cmbPayType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPayType.SelectedIndex == 0)
            {
                (salesOrderGridView.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("id > {0}", 0);
            }
            else
            {
                int statusId = cmbPayType.SelectedIndex;
                (salesOrderGridView.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("PayType = '{0}'", ((PayType)statusId).ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmSalesOrderAdd = new frmSalesOrderAdd(this, userId);
            frmSalesOrderAdd.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (salesOrderGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow dataRow = salesOrderGridView.SelectedRows[0];
                int.TryParse(dataRow.Cells["id"].Value.ToString(), out int id);
                if (id < 0)
                    return;

                var frmSalesOrderAdd = new frmSalesOrderAdd(this, userId, id);
                frmSalesOrderAdd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an order to update");
            }
        }

        private void dataRowDouble_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dataRow = salesOrderGridView.Rows[e.RowIndex];
            int.TryParse(dataRow.Cells["id"].Value.ToString(), out int id);
            if (id < 0)
                return;

            var frmSalesOrderAdd = new frmSalesOrderAdd(this, userId, id);
            frmSalesOrderAdd.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {

        }

        private void btnViewItems_Click(object sender, EventArgs e)
        {

        }
    }
}
