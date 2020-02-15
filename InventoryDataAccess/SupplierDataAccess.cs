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

        public static int AddSupplier(SupplierDTO supplierDto)
        {
            string query = "INSERT INTO supplier (name, tel_mobile, email, is_active, created_by) VALUES " +
                "( " +  "'" + supplierDto.Name + "','" + supplierDto.Mobile + "','" + supplierDto.Email + "'," + supplierDto.IsActive + "," + supplierDto.CreatedBy + ")";

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

        public static int UpdateSupplier(SupplierDTO supplierDto)
        {
            string query = "UPDATE supplier SET name = '" + supplierDto.Name + "', tel_mobile = '" + supplierDto.Mobile + 
                "', email = '" + supplierDto.Email + "', is_active = " + supplierDto.IsActive +
                ", updated_by = " + supplierDto.UpdatedBy + ", updated_at = '" + DateTime.Now + "' WHERE id = " + supplierDto.Id;

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

        public static int DeleteSupplier(int supplierId)
        {
            string query = "Delete FROM supplier WHERE id = " + supplierId;
            DataTable supplierTable = DatabaseConnection.ConnectWithServer(query);
            if (supplierTable != null)
            {
                return 1;
            }
            return -1;
        }
    }
}
