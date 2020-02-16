using InventoryDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Product
{
    public partial class frmProducts : Form
    {
        private int userId;
        private IDictionary<int, string> keyValues;
        private List<int> categoryIds = new List<int>();

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
            if (cmbCategory.Items.Count < 1)
                ViewCategories();
        }

        private void ViewCategories()
        {
            keyValues = CategoryDataAccess.GetCategoriesForProduct();
            if (keyValues != null)
            {
                cmbCategory.Items.Add("All");
                foreach (var item in keyValues)
                {
                    cmbCategory.Items.Add(item.Value);
                    categoryIds.Add(item.Key);
                }
            }
            cmbCategory.SelectedIndex = 0;
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
                    //case "Status":
                    //    productGridView.Columns[i].Width = 90;
                    //    break;
                    case "Title":
                        productGridView.Columns[i].Width = 150;
                        break;
                    case "category_id":
                        productGridView.Columns[i].Visible = false;
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

        private void btnAdminSearch_Click(object sender, EventArgs e)
        {
            string searchTxt = txtSearch.Text;
            if (string.IsNullOrEmpty(searchTxt))
            {
                frmProduct_Load(sender, e);
            }
            else if (searchTxt.Length < 3)
            {
                MessageBox.Show("Please enter minimum 3 characters");
                txtSearch.Text = "";
                return;
            }

            if (productGridView != null)
            {
                (productGridView.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("Name LIKE '%{0}%' OR Title LIKE '%{0}%' OR Code LIKE '%{0}%'", searchTxt);
            }
            txtSearch.Text = "";
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex == 0)
            {
                (productGridView.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("category_id > {0}", 0);
            }
            else
            {
                int categoryId = categoryIds[cmbCategory.SelectedIndex]-1;
                (productGridView.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("category_id = {0}", categoryId);
            }
        }
    }
}
