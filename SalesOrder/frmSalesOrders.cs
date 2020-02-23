using InventoryDataAccess;
using SalesItem;
using Syncfusion.XlsIO;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static Common.OrderInfo;

namespace SalesOrder
{
    public partial class frmSalesOrders : Form
    {
        private int userId;
        private DataTable salesOrderTable;

        public frmSalesOrders(int userId)
        {
            this.userId = userId;
            InitializeComponent();
        }

        public void frmSalesOrders_Load(object sender, EventArgs e)
        {
            salesOrderTable = SalesOrderDataAccess.GetSalesOrders();
            if (salesOrderTable != null)
            {
                this.salesOrderGridView.DataSource = salesOrderTable;
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
            if (salesOrderGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow dataRow = salesOrderGridView.SelectedRows[0];
                int.TryParse(dataRow.Cells["id"].Value.ToString(), out int id);
                if (id < 0)
                    return;

                var frmSalesItemAdd = new frmSalesItemAdd(this, userId, id);
                frmSalesItemAdd.ShowDialog();
            }
            else
                MessageBox.Show("Please select an order to add items");
        }

        private void btnViewItems_Click(object sender, EventArgs e)
        {
            if (salesOrderGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow dataRow = salesOrderGridView.SelectedRows[0];
                int.TryParse(dataRow.Cells["id"].Value.ToString(), out int id);
                if (id < 0)
                    return;

                DataTable dt = SalesOrderItemDataAccess.GetSalesItems(id);
                if (dt != null && dt.Rows.Count > 0)
                {
                    var frmSalesItems = new frmSalesItems(this, userId, id, dt);
                    frmSalesItems.ShowDialog();
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelEngine excelEngine = new ExcelEngine();
                IApplication application = excelEngine.Excel;

                application.DefaultVersion = ExcelVersion.Excel2010;

                //Create a new workbook
                IWorkbook workbook = application.Workbooks.Create(1);

                //Access first worksheet from the workbook instance
                IWorksheet worksheet = workbook.Worksheets[0];

                //Exporting DataTable to worksheet
                worksheet.ImportDataTable(salesOrderTable, true, 1, 1);
                worksheet.UsedRange.AutofitColumns();

                var curDir = Directory.GetCurrentDirectory();
                var rootPath = Directory.GetDirectoryRoot(curDir);

                var folderPath = rootPath + "InventoryReports\\";
                DirectoryInfo di = null;
                if (!Directory.Exists(folderPath))
                {
                    //Create folder
                    di = Directory.CreateDirectory(folderPath);
                }

                var outputFilePath = folderPath + "salesOrderReport.xlsx";
                if (File.Exists(outputFilePath))
                {
                    File.Delete(outputFilePath);
                }

                //Save the workbook to disk in xlsx format
                workbook.SaveAs(outputFilePath);
                MessageBox.Show("Successfully exported to " + outputFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
