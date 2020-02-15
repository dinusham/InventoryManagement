using InventoryDataAccess;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Brand
{
    public partial class frmBrands : Form
    {
        private int userId;

        public frmBrands(int userId)
        {
            this.userId = userId;
            InitializeComponent();
        }

        public void frmBrands_Load(object sender, System.EventArgs e)
        {
            DataTable dt = BrandDataAccess.GetBrands();
            if (dt != null)
            {
                this.brandGridView.DataSource = dt;
                FormatGrid(ref this.brandGridView);
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
                    case "CreatedBy":
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
            var frmBrandAdd = new frmBrandAdd(this, userId);
            frmBrandAdd.ShowDialog();
        }

        private void dataRowDouble_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dataRow = brandGridView.Rows[e.RowIndex];
            int.TryParse(dataRow.Cells["id"].Value.ToString(), out int id);
            if (id < 0)
                return;

            var frmBrandAdd = new frmBrandAdd(this, userId, id);
            frmBrandAdd.ShowDialog();
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            if (brandGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow dataRow = brandGridView.SelectedRows[0];
                int.TryParse(dataRow.Cells["id"].Value.ToString(), out int id);
                if (id < 0)
                    return;

                var frmBrandAdd = new frmBrandAdd(this, userId, id);
                frmBrandAdd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a brand to update");
            }
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (brandGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow dataRow = brandGridView.SelectedRows[0];
                int.TryParse(dataRow.Cells["id"].Value.ToString(), out int id);
                if (id < 0)
                {
                    MessageBox.Show("Invalid brand id");
                    return;
                }
                else
                {
                    int success = BrandDataAccess.DeleteBrand(id);
                    if (success > 0)
                    {
                        MessageBox.Show("successfully deleted");
                        frmBrands_Load(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a brand to delete");
                return;
            }
        }
    }
}
