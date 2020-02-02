using System.Data;

namespace InventoryDataAccess
{
    public class InventoryLogin
    {
        public static (bool, bool, bool) IsValidLogin(string useName, string password)
        {
            string query = "SELECT user_role, is_active FROM admin WHERE user_name = '" + useName + "' AND password = '" + password  + "'";

            DataTable usersTable = DatabaseConnection.ConnectWithServer(query);
            if (usersTable != null && usersTable.Rows.Count > 0)
            {
                DataRow dataRow = usersTable.Rows[0];
                bool isAdmin = int.Parse(dataRow["user_role"].ToString()) == 1 ? true : false;
                bool isActive = int.Parse(dataRow["is_active"].ToString()) == 1 ? true : false;
                return (true, isAdmin, isActive);
            }
            return (false, false, false);
        }
    }
}
