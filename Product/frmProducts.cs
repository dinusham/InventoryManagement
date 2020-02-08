using InventoryDataAccess;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Product
{
    public partial class frmProducts : Form
    {
        private int userId;

        public frmProducts(int userId)
        {
            this.userId = userId;
            InitializeComponent();
        }

        public void frmProduct_Load(object sender, System.EventArgs e)
        {
            DataTable dt = ProductDataAccess.GetProducts();
            if (dt != null)
            {
                this.productGridView.DataSource = dt;
                FormatGrid(ref this.productGridView);
            }
        }

        private void FormatGrid(ref DataGridView productGridView)
        {
            for (int i = 0; i < productGridView.Columns.Count; i++)
            {
                string colunmName = productGridView.Columns[i].Name;
                switch (colunmName)
                {
                    case "id":
                        productGridView.Columns[i].Visible = false;
                        break;
                    case "Name":
                        productGridView.Columns[i].Width = 140;
                        break;
                    case "Status":
                        productGridView.Columns[i].Width = 90;
                        break;
                    case "Title":
                        productGridView.Columns[i].Width = 150;
                        break;
                    default:
                        break;
                }
            }

            foreach (DataGridViewRow row in productGridView.Rows)
            {
                if (row.Index % 2 == 0)
                    row.DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmProductAdd = new frmProductAdd(this, userId);
            frmProductAdd.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (productGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow dataRow = productGridView.SelectedRows[0];
                int.TryParse(dataRow.Cells["id"].Value.ToString(), out int id);
                if (id < 0)
                    return;

                var frmProductAdd = new frmProductAdd(this, userId, id);
                frmProductAdd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a brand to update");
            }
        }

        private void dataRowDouble_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dataRow = productGridView.Rows[e.RowIndex];
            int.TryParse(dataRow.Cells["id"].Value.ToString(), out int id);
            if (id < 0)
                return;

            var frmProductAdd = new frmProductAdd(this, userId, id);
            frmProductAdd.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
