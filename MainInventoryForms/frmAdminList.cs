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
                this.dataGridViewAdmin.AllowUserToAddRows = false;
                //this.dataGridViewAdmin.ReadOnly = true;

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
                    case "first_name":
                        dataGridView.Columns[i].Name = "Name";
                        dataGridView.Columns[i].Width = 242;
                        break;
                    case "last_name":
                        dataGridView.Columns[i].Visible = false;
                        break;
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
                row.Cells["Name"].Value = row.Cells["Name"].Value.ToString() + " " + row.Cells["last_name"].Value.ToString();

                if (row.Index %2 == 0)
                    row.DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        private void btnAdminAdd_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "frmUserAdd")
                {
                    isOpen = true;
                    form.BringToFront();
                    break;
                }
            }

            if (!isOpen)
            {
                var frmUserAdd = new frmUserAdd(this);
                frmUserAdd.Show();
            }
        }

        private void dataRowDouble_Click(object sender, DataGridViewCellEventArgs e)
        {
            bool isOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "frmUserAdd")
                {
                    isOpen = true;
                    form.BringToFront();
                    break;
                }
            }

            if (!isOpen)
            {
                var dtaRow = dataGridViewAdmin.Rows[e.RowIndex];
                var userDto = GetGridRowData(dtaRow);

                if (userDto != null)
                {
                    var frmUserAdd = new frmUserAdd(this, userDto);
                    frmUserAdd.Show();
                }
                return;
            }
        }

        private UserDTO GetGridRowData(DataGridViewRow dataRow)
        {
            if (dataRow == null)
                return null;

            int.TryParse(dataRow.Cells["id"].Value.ToString(), out int id);
            if (id < 0)
                return null;

            string name = dataRow.Cells["Name"].Value.ToString();

            return new UserDTO
            {
                Id = id,
                FirstName = name.Replace(dataRow.Cells["last_name"].Value.ToString(), ""),
                LastName = dataRow.Cells["last_name"].Value.ToString(),
                Email = dataRow.Cells["Email"].Value.ToString(),
                Mobile = dataRow.Cells["Mobile"].Value.ToString(),
                UserName = dataRow.Cells["UserName"].Value.ToString(),
                Password = dataRow.Cells["Password"].Value.ToString()
            };
        }

        private void btnAdminEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewAdmin.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewAdmin.SelectedRows[0];
                bool isOpen = false;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Text == "frmUserAdd")
                    {
                        isOpen = true;
                        form.BringToFront();
                        break;
                    }
                }

                if (!isOpen)
                {
                    var userDto = GetGridRowData(row);

                    if (userDto != null)
                    {
                        var frmUserAdd = new frmUserAdd(this, userDto);
                        frmUserAdd.Show();
                    }
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select a user to edit");
            }
        }
    }
}
