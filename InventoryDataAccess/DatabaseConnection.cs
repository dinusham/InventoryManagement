using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace InventoryDataAccess
{
    public  class DatabaseConnection
    {
        public static DataTable ConnectWithServer(string query)
        {
            string connstring = string.Format("Server=localhost; database=esft_ad_inventory_mgt; UID=root; password=''");
            MySqlConnection connection = new MySqlConnection(connstring);
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter(commandDatabase);
                DataTable table = new DataTable();
                adapter.Fill(table);

                connection.Close();
                adapter.Dispose();

                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
    }
}
