using System.Data;

namespace InventoryDataAccess
{
    public class Admin
    {
        public static DataTable GetAllUsers()
        {
            string query = "SELECT  id, CONCAT(first_name, ' ', last_name) AS Name, tel_mobile AS Mobile, " +
                "email AS Email, create_at AS CreatedDate FROM admin ORDER BY id";

            DataTable users = DatabaseConnection.ConnectWithServer(query);

            return users;
        }
    }
}
