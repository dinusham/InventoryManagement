using System;
using System.Data;

namespace InventoryDataAccess
{
    public class SupplierDataAccess
    {
        public static DataTable GetSuppliers()
        {
            string query = "SELECT  id, name AS Name, tel_mobile AS Mobile, email AS Email, " +
                "IF(is_active = 1, 'Active', 'Inactive') AS Status FROM supplier";

            DataTable supplierTable = DatabaseConnection.ConnectWithServer(query);

            return supplierTable;
        }

        public static int AddSupplier(CustomerDTO customerDto)
        {
            string query = "INSERT INTO customer (name, tel_mobile, email, is_active, created_by) VALUES " +
                "( " +  "'" + customerDto.Name + "','" + customerDto.Mobile + "','" + customerDto.Email + "'," + customerDto.IsActive + "," + customerDto.CreatedBy + ")";

            try
            {
                DataTable supplierTable = DatabaseConnection.ConnectWithServer(query);
                if (supplierTable == null)
                    return -1;

                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static int UpdateSupplier(CustomerDTO customerDto)
        {
            string query = "UPDATE customer SET name = '" + customerDto.Name + "', tel_mobile = '" + customerDto.Mobile + 
                "', email = '" + customerDto.Email + "', is_active = " + customerDto.IsActive +
                ", updated_by = " + customerDto.UpdatedBy + ", updated_at = '" + DateTime.Now + "' WHERE id = " + customerDto.Id;

            try
            {
                DataTable supplierTable = DatabaseConnection.ConnectWithServer(query);
                if (supplierTable == null)
                    return -1;

                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static SupplierDTO GetSupplierById(int supplierId)
        {
            string query = "SELECT  id, name, tel_mobile, email, is_active FROM supplier WHERE id = " + supplierId;

            try
            {
                DataTable supplierTable = DatabaseConnection.ConnectWithServer(query);
                if (supplierTable != null && supplierTable.Rows.Count > 0)
                {
                    DataRow dataRow = supplierTable.Rows[0];

                    return new SupplierDTO
                    {
                        Id = int.Parse(dataRow["id"].ToString()),
                        Name = dataRow["name"].ToString(),
                        Mobile = dataRow["tel_mobile"].ToString(),
                        Email = dataRow["email"].ToString(),
                        IsActive = (bool)dataRow["is_active"]
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static int DeleteSupplier(int brandId)
        {
            string query = "Delete FROM customer WHERE id = " + brandId;
            DataTable supplierTable = DatabaseConnection.ConnectWithServer(query);
            if (supplierTable != null)
            {
                return 1;
            }
            return -1;
        }
    }
}
