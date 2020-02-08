using System;
using System.Data;

namespace InventoryDataAccess
{
    public class AdminDataAccess
    {
        public static DataTable GetAllUsers()
        {
            string query = "SELECT  id, concat(first_name, ' ' , last_name) as Name, tel_mobile AS Mobile, " +
                "email AS Email, user_name AS UserName, password as Password, create_at AS CreatedDate FROM admin ORDER BY id";

            DataTable users = DatabaseConnection.ConnectWithServer(query);

            return users;
        }

        public static int AddAdmin(AdminDTO userDto)
        {
            DateTime dateTime = DateTime.Now.Date;

            string query = "INSERT INTO admin (first_name, last_name, tel_mobile, " +
                "email, user_name, password, create_at) VALUES (" + "'" + userDto.FirstName + "','" + userDto.LastName + 
                "','" + userDto.Mobile + "','" + userDto.Email + "','" + userDto.UserName + "',SHA1('" + userDto.Password + 
                "'),'" + dateTime + "')";

            DataTable usersTable = DatabaseConnection.ConnectWithServer(query);
            if (usersTable != null)
            {
                return 1;
            }
            return -1;
        }

        public static int UpdateAdmin(AdminDTO userDto)
        {
            string query = "UPDATE admin SET first_name = '" + userDto.FirstName + "',last_name = '" + userDto.LastName +
                "', tel_mobile = '" + userDto.Mobile + "', email = '" + userDto.Email + "', user_name = '" + userDto.UserName +
                "', password = SHA1('" + userDto.Password + "') WHERE id = " + userDto.Id;

            DataTable usersTable = DatabaseConnection.ConnectWithServer(query);
            if (usersTable != null)
            {
                return 1;
            }
            return -1;
        }

        public static AdminDTO GetAdminInfoById(int adminId)
        {
            string query = "SELECT id, first_name, last_name, tel_mobile, email, user_name, password, user_role, " +
                "is_active FROM admin WHERE id = " + adminId;

            DataTable usersTable = DatabaseConnection.ConnectWithServer(query);
            if (usersTable != null && usersTable.Rows.Count > 0)
            {
                DataRow dataRow = usersTable.Rows[0];
                return new AdminDTO
                {
                    Id = int.Parse(dataRow["id"].ToString()),
                    FirstName = dataRow["first_name"].ToString(),
                    LastName = dataRow["last_name"].ToString(),
                    Email = dataRow["email"].ToString(),
                    Mobile = dataRow["tel_mobile"].ToString(),
                    UserName = dataRow["user_name"].ToString(),
                    Password = dataRow["password"].ToString()
                };
            }
            return null;
        }

        public static int DeleteAdmin(int adminId)
        {
            string query = "Delete FROM admin WHERE id = " + adminId;

            DataTable usersTable = DatabaseConnection.ConnectWithServer(query);
            if (usersTable != null)
            {
                return 1;
            }
            return -1;
        }
    }
}
