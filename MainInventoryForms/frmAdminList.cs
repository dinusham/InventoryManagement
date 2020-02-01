using InventoryDataAccess;
using System;
using System.Data;
using System.Windows.Forms;

namespace MainInventoryForms
{
    public partial class frmAdminList : Form
    {
        public frmAdminList()
        {
            InitializeComponent();
            //var databaseConnection = new DatabaseConnection();
            //databaseConnection.ConnectWithServer();
        }

        private void frmAdminList_Load(object sender, EventArgs e)
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
                        dataGridView.Columns[i].Width = 0;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
