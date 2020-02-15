using InventoryDataAccess;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Supplier
{
    public partial class frmSuppliers : Form
    {
        private int userId;

        public frmSuppliers(int userId)
        {
            this.userId = userId;
            InitializeComponent();
        }

        public void frmSuppliers_Load(object sender, System.EventArgs e)
        {
            DataTable dt = SupplierDataAccess.GetSuppliers();
            if (dt != null)
            {
                this.supplierDataGridView.DataSource = dt;
                FormatGrid(ref this.supplierDataGridView);
            }
        }

        private void FormatGrid(ref DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                string colunmName = dataGridView.Columns[i].Name;
                switch (colunmName)
                {
                    case "id":
                        dataGridView.Columns[i].Visible = false;
                        break;
                    case "Name":
                        dataGridView.Columns[i].Width = 140;
                        break;
                    case "Status":
                        dataGridView.Columns[i].Width = 90;
                        break;
                    case "Email":
                        dataGridView.Columns[i].Width = 150;
                        break;
                    default:
                        break;
                }
            }

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Index % 2 == 0)
                    row.DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            var frmSupplierAdd = new frmSupplierAdd(this, userId);
            frmSupplierAdd.ShowDialog();
        }

        private void dataRowDouble_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dataRow = supplierDataGridView.Rows[e.RowIndex];
            int.TryParse(dataRow.Cells["id"].Value.ToString(), out int id);
            if (id < 0)
                return;

            var frmCustomerAdd = new frmSupplierAdd(this, userId, id);
            frmCustomerAdd.ShowDialog();
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            if (supplierDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow dataRow = supplierDataGridView.SelectedRows[0];
                int.TryParse(dataRow.Cells["id"].Value.ToString(), out int id);
                if (id < 0)
                    return;

                var frmCustomerAdd = new frmSupplierAdd(this, userId, id);
                frmCustomerAdd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a supplier to update");
            }
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {

        }
    }
}
