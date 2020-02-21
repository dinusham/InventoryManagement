using System;
using System.Collections.Generic;
using System.Data;

namespace InventoryDataAccess
{
    public class CustomerDataAccess
    {
        public static DataTable GetCustomers()
        {
            string query = "SELECT  id, name AS Name, tel_mobile AS Mobile, email AS Email, " +
                "IF(is_active = 1, 'Active', 'Inactive') AS Status FROM customer";

            DataTable customerTable = DatabaseConnection.ConnectWithServer(query);

            return customerTable;
        }

        public static int AddCustomer(CustomerDTO customerDto)
        {
            string query = "INSERT INTO customer (name, tel_mobile, email, is_active, created_by) VALUES " +
                "( " +  "'" + customerDto.Name + "','" + customerDto.Mobile + "','" + customerDto.Email + "'," + customerDto.IsActive + "," + customerDto.CreatedBy + ")";

            try
            {
                DataTable customerTable = DatabaseConnection.ConnectWithServer(query);
                if (customerTable == null)
                    return -1;

                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static int UpdateCustomer(CustomerDTO customerDto)
        {
            string query = "UPDATE customer SET name = '" + customerDto.Name + "', tel_mobile = '" + customerDto.Mobile + 
                "', email = '" + customerDto.Email + "', is_active = " + customerDto.IsActive +
                ", updated_by = " + customerDto.UpdatedBy + ", updated_at = '" + DateTime.Now + "' WHERE id = " + customerDto.Id;

            try
            {
                DataTable customerTable = DatabaseConnection.ConnectWithServer(query);
                if (customerTable == null)
                    return -1;

                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static CustomerDTO GetCustomerById(int customerId)
        {
            string query = "SELECT  id, name, tel_mobile, email, is_active FROM customer WHERE id = " + customerId;

            try
            {
                DataTable customerTable = DatabaseConnection.ConnectWithServer(query);
                if (customerTable != null && customerTable.Rows.Count > 0)
                {
                    DataRow dataRow = customerTable.Rows[0];

                    return new CustomerDTO
                    {
                        Id = int.Parse(dataRow["id"].ToString()),
                        Name = dataRow["name"].ToString(),
                        Mobile = dataRow["tel_mobile"].ToString(),
                        Email = dataRow["email"].ToString(),
                        IsActive = (dataRow["is_active"].ToString() == "1") ? true : false
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static int DeleteCustomer(int customerId)
        {
            string query = "Delete FROM customer WHERE id = " + customerId;
            DataTable customerTable = DatabaseConnection.ConnectWithServer(query);
            if (customerTable != null)
            {
                return 1;
            }
            return -1;
        }

        public static IDictionary<int, string> GetCustomersForSalesOrder()
        {
            string query = "SELECT id, name FROM customer WHERE is_active = " + true + " ORDER By id";

            DataTable customers = DatabaseConnection.ConnectWithServer(query);

            if (customers != null && customers.Rows.Count > 0)
            {
                var keyValues = new Dictionary<int, string>();
                foreach (DataRow row in customers.Rows)
                {
                    keyValues.Add(int.Parse(row["id"].ToString()), row["name"].ToString());
                }
                return keyValues;
            }
            return null;
        }
    }
}
