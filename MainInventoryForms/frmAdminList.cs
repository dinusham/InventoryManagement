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
                    case "Name":
                        dataGridView.Columns[i].Width = 242;
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

        private void dataRowDouble_Click(object sende, DataGridViewCellEventArgs e)
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
                var userDto = GetGridRowData(e);

                if (userDto != null)
                {
                    var frmUserAdd = new frmUserAdd(this, userDto);
                    frmUserAdd.Show();
                }
                return;
            }
        }

        private UserDTO GetGridRowData(DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (e.ColumnIndex < 0 || row < 0)
                return null;

            var dtaRow = dataGridViewAdmin.Rows[row];

            int.TryParse(dtaRow.Cells["id"].Value.ToString(), out int id);
            if (id < 0)
                return null;

            string name = dtaRow.Cells["Name"].Value.ToString();
            string[] names = name.Split(' ');

            return new UserDTO
            {
                Id = id,
                FirstName = names[0],
                LastName = names[1],
                Email = dtaRow.Cells["Email"].Value.ToString(),
                Mobile = dtaRow.Cells["Mobile"].Value.ToString(),
                UserName = dtaRow.Cells["UserName"].Value.ToString(),
                Password = dtaRow.Cells["Password"].Value.ToString()
            };
        }

        private void btnAdminEdit_Click(object sender, EventArgs e)
        {
            //DataGridView row = (DataGridViewRow)dataGridViewAdmin.Rows[e.];
        }
    }
}
