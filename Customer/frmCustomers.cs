using InventoryDataAccess;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Customer
{
    public partial class frmCustomers : Form
    {
        private int userId;

        public frmCustomers(int userId)
        {
            this.userId = userId;
            InitializeComponent();
        }

        public void frmCustomers_Load(object sender, System.EventArgs e)
        {
            DataTable dt = CustomerDataAccess.GetCustomers();
            if (dt != null)
            {
                this.customerDataGridView.DataSource = dt;
                FormatGrid(ref this.customerDataGridView);
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
            var frmCustomerAdd = new frmCustomerAdd(this, userId);
            frmCustomerAdd.ShowDialog();
        }

        private void dataRowDouble_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dataRow = customerDataGridView.Rows[e.RowIndex];
            int.TryParse(dataRow.Cells["id"].Value.ToString(), out int id);
            if (id < 0)
                return;

            var frmCustomerAdd = new frmCustomerAdd(this, userId, id);
            frmCustomerAdd.ShowDialog();
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            if (customerDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow dataRow = customerDataGridView.SelectedRows[0];
                int.TryParse(dataRow.Cells["id"].Value.ToString(), out int id);
                if (id < 0)
                    return;

                var frmCustomerAdd = new frmCustomerAdd(this, userId, id);
                frmCustomerAdd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a customer to update");
            }
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (customerDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow dataRow = customerDataGridView.SelectedRows[0];
                int.TryParse(dataRow.Cells["id"].Value.ToString(), out int id);
                if (id < 0)
                {
                    MessageBox.Show("Invalid customer id");
                    return;
                }
                else
                {
                    int success = CustomerDataAccess.DeleteCustomer(id);
                    if (success > 0)
                    {
                        MessageBox.Show("successfully deleted");
                        frmCustomers_Load(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete");
                return;
            }
        }
    }
}
