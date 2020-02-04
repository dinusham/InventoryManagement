using InventoryDataAccess;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CategoryForms
{
    public partial class frmCategory : Form
    {
        private int userId;

        public frmCategory(int userId)
        {
            this.userId = userId;
            InitializeComponent();
        }

        public void frmCategory_Load(object sender, EventArgs e)
        {
            DataTable dt = CategoryDataAccess.GetCategories();
            if (dt != null)
            {
                this.cateroryGridView.DataSource = dt;
                FormatGrid(ref this.cateroryGridView);
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
                        dataGridView.Columns[i].Width = 150;
                        break;
                    case "IsActive":
                        dataGridView.Columns[i].Name = "Is active";
                        dataGridView.Columns[i].Width = 110;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmCategoryAdd = new frmCategoryAdd(this, userId);
            frmCategoryAdd.ShowDialog();
        }

        private void dataRowDouble_Click(object sender, DataGridViewCellEventArgs e)
        {
            var dataRow = cateroryGridView.Rows[e.RowIndex];
            int.TryParse(dataRow.Cells["id"].Value.ToString(), out int id);
            if (id < 0)
                return;

            var frmCategoryAdd = new frmCategoryAdd(this, userId, id);
            frmCategoryAdd.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cateroryGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow dataRow = cateroryGridView.SelectedRows[0];
                int.TryParse(dataRow.Cells["id"].Value.ToString(), out int id);
                if (id < 0)
                    return;

                var frmCategoryAdd = new frmCategoryAdd(this, userId, id);
                frmCategoryAdd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a category to update");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cateroryGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow dataRow = cateroryGridView.SelectedRows[0];
                int.TryParse(dataRow.Cells["id"].Value.ToString(), out int id);
                if (id < 0)
                {
                    MessageBox.Show("Invalid category id");
                    return;
                }
                else
                {
                    int success = CategoryDataAccess.DeleteCategory(id);
                    if (success > 0)
                    {
                        MessageBox.Show("successfully deleted");
                        frmCategory_Load(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a category to delete");
                return;
            }
        }
    }
}