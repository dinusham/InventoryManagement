using InventoryDataAccess;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SalesItem
{
    public partial class frmSalesItems : Form
    {
        private Form frmSalesItem;
        private int orderId;
        private int userId;
        private DataTable salesItemTable;

        public frmSalesItems(Form frmSalesItem, int userId, int orderId, DataTable dataTable)
        {
            this.frmSalesItem = frmSalesItem;
            this.userId = userId;
            this.orderId = orderId;
            salesItemTable = dataTable;
            InitializeComponent();
        }

        private void frmSalesItems_Load(object sender, EventArgs e)
        {
            //if (salesItemTable == null || salesItemTable.Rows.Count < 0)
            //{
            //    salesItemTable = .GetOrderItems(orderId);
            //}
            salesItemTable = SalesOrderItemDataAccess.GetSalesItems(orderId);
            this.salesItemGridView.DataSource = salesItemTable;
            FormatGrid(ref this.salesItemGridView);
        }

        private void FormatGrid(ref DataGridView orderGridView)
        {
            for (int i = 0; i < orderGridView.Columns.Count; i++)
            {
                string colunmName = orderGridView.Columns[i].Name;
                switch (colunmName)
                {
                    case "id":
                    case "sale_id":
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
            var frmSalesItemAdd = new frmSalesItemAdd(this, userId, orderId, true);
            frmSalesItemAdd.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (salesItemGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow dataRow = salesItemGridView.SelectedRows[0];
                int.TryParse(dataRow.Cells["id"].Value.ToString(), out int id);
                if (id < 0)
                    return;

                var frmSalesItemAdd = new frmSalesItemAdd(this, userId, orderId, id);
                frmSalesItemAdd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an order to update");
            }
        }

        private void dataRowDouble_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dataRow = salesItemGridView.Rows[e.RowIndex];
            int.TryParse(dataRow.Cells["id"].Value.ToString(), out int id);
            if (id < 0)
                return;

            var frmSalesItemAdd = new frmSalesItemAdd(this, userId, orderId, id);
            frmSalesItemAdd.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
