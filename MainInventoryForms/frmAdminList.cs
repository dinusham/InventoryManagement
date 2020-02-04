using InventoryDataAccess;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MainInventoryForms
{
    public partial class frmAdminList : Form
    {
        public frmAdminList()
        {
            InitializeComponent();
        }

        public void frmAdminList_Load(object sender, EventArgs e)
        {
            DataTable dt = Admin.GetAllUsers();

            if (dt != null)
            {
                this.dataGridViewAdmin.DataSource = dt;
                FormatGrid(ref this.dataGridViewAdmin);
            }
        }

        private void FormatGrid(ref DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                string colunmName = dataGridView.Columns[i].Name;
                switch (colunmName)
                {
                    case "Name":
                        //dataGridView.Columns[i].Name = "Name";
                        dataGridView.Columns[i].Width = 242;
                        break;
                    //case "last_name":
                    //    dataGridView.Columns[i].Visible = false;
                    //    break;
                    case "Email":
                        dataGridView.Columns[i].Width = 180;
                        break;
                    case "Mobile":
                        dataGridView.Columns[i].Width = 140;
                        break;
                    case "CreatedDate":
                        dataGridView.Columns[i].Name = "Created Date";
                        dataGridView.Columns[i].Width = 160;
                        break;
                    case "id":
                        dataGridView.Columns[i].Visible = false;
                        break;
                    case "UserName":
                        dataGridView.Columns[i].Visible = false;
                        break;
                    case "Password":
                        dataGridView.Columns[i].Visible = false;
                        break;
                    default:
                        break;
                }
            }

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Index %2 == 0)
                    row.DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        private void btnAdminAdd_Click(object sender, EventArgs e)
        {
            var frmUserAdd = new frmAdminAdd(this);
            frmUserAdd.ShowDialog();
        }

        private void dataRowDouble_Click(object sender, DataGridViewCellEventArgs e)
        {
            var dataRow = dataGridViewAdmin.Rows[e.RowIndex];
            int.TryParse(dataRow.Cells["id"].Value.ToString(), out int id);
            if (id < 0)
                return;

            var frmUserAdd = new frmAdminAdd(this, id);
            frmUserAdd.ShowDialog();
        }

        private void btnAdminEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewAdmin.SelectedRows.Count > 0)
            {
                DataGridViewRow dataRow = dataGridViewAdmin.SelectedRows[0];
                int.TryParse(dataRow.Cells["id"].Value.ToString(), out int id);
                if (id < 0)
                    return;

                var frmUserAdd = new frmAdminAdd(this, id);
                frmUserAdd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a user to update");
            }
        }

        private void btnAdminDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAdmin.SelectedRows.Count > 0)
            {
                DataGridViewRow dataRow = dataGridViewAdmin.SelectedRows[0];
                int.TryParse(dataRow.Cells["id"].Value.ToString(), out int id);
                if (id < 0)
                {
                    MessageBox.Show("Invalid user id");
                    return;
                }
                else
                {
                    int success = Admin.DeleteAdmin(id);
                    if (success > 0)
                    {
                        MessageBox.Show("successfully deleted");
                        frmAdminList_Load(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete");
                return;
            }
        }

        private void btnAdminSearch_Click(object sender, EventArgs e)
        {
            string searchTxt = textBoxSearchAdmin.Text;
            if (string.IsNullOrEmpty(searchTxt))
            {
                frmAdminList_Load(sender, e);
            }
            else if (searchTxt.Length < 3)
            {
                MessageBox.Show("Please enter minimum 3 characters");
                textBoxSearchAdmin.Text = "";
                return;
            }

            if (dataGridViewAdmin != null)
            {
                (dataGridViewAdmin.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("Name LIKE '%{0}%'", searchTxt);
            }
            textBoxSearchAdmin.Text = "";
        }
    }
}