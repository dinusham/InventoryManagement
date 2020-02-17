using System.Collections.Generic;
using System.Data;

namespace InventoryDataAccess
{
    public class InventoryLogin
    {
        public static AdminDTO IsValidLogin(string useName, string password)
        {
            string query = "SELECT id, user_role, is_active FROM admin WHERE user_name = '" + useName + "' AND password = SHA1('" + password + "')";

            DataTable usersTable = DatabaseConnection.ConnectWithServer(query);
            if (usersTable != null && usersTable.Rows.Count > 0)
            {
                DataRow dataRow = usersTable.Rows[0];
                return new AdminDTO
                {
                    Id = int.Parse(dataRow["id"].ToString()),
                    UserName = useName,
                    IsAdmin = int.Parse(dataRow["user_role"].ToString()) == 1 ? true : false,
                    IsActive = int.Parse(dataRow["is_active"].ToString()) == 1 ? true : false
                };
            }
            return null;
        }

        public static int UpdatePassword(int adminId, string password)
        {
            string query = "UPDATE admin SET password = '" + password  + "' WHERE id = " + adminId;
            DataTable usersTable = DatabaseConnection.ConnectWithServer(query);

            if (usersTable != null)
            {
                return 1;
            }
            return -1;
        }

        public static DashboardSummaryDTO GetDashboardSummaryInfo()
        {
            return null;
        }
    }
}
