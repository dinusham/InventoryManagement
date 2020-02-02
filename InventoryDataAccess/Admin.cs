using System;
using System.Data;

namespace InventoryDataAccess
{
    public class Admin
    {
        public static DataTable GetAllUsers()
        {
            string query = "SELECT  id, first_name, last_name, tel_mobile AS Mobile, " +
                "email AS Email, user_name AS UserName, password as Password, create_at AS CreatedDate FROM admin ORDER BY id";

            DataTable users = DatabaseConnection.ConnectWithServer(query);

            return users;
        }

        public static int AddUser(UserDTO userDto)
        {
            DateTime dateTime = DateTime.Now.Date;

            string query = "INSERT INTO admin (first_name, last_name, tel_mobile, " +
                "email, user_name, password, create_at) VALUES (" + "'" + userDto.FirstName + "','" + userDto.LastName + 
                "','" + userDto.Mobile + "','" + userDto.Email + "','" + userDto.UserName + "','" + userDto.Password + 
                "','" + dateTime + "')";

            DataTable usersTable = DatabaseConnection.ConnectWithServer(query);
            if (usersTable != null)
            {
                return 1;
            }
            return -1;
        }

        public static int UpdateUser(UserDTO userDto)
        {
            string query = "UPDATE admin SET first_name = '" + userDto.FirstName + "',last_name = '" + userDto.LastName +
                "', tel_mobile = '" + userDto.Mobile + "', email = '" + userDto.Email + "', user_name = '" + userDto.Email +
                "', password = '" + userDto.Password + "' WHERE id = " + userDto.Id;

            DataTable usersTable = DatabaseConnection.ConnectWithServer(query);
            if (usersTable != null)
            {
                return 1;
            }
            return -1;
        }
    }
}
