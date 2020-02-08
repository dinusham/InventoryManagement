using System;
using System.Data;

namespace InventoryDataAccess
{
    public class BrandDataAccess
    {
        public static DataTable GetBrands()
        {
            string query = "SELECT  b.id, b.name AS Name, IF(b.is_active = 1, 'Active', 'Inactive') AS Status, " +
                "CONCAT(a.first_name, ' ', a.last_name) AS Created  FROM brand b, admin a WHERE b.created_by = a.id";

            DataTable brandsTable = DatabaseConnection.ConnectWithServer(query);

            return brandsTable;
        }

        public static int AddBrand(BrandDTO brandDto)
        {
            string query = "INSERT INTO brand (NAME, is_active, created_by) VALUES " +
                "( " +  "'" + brandDto.BrandName + "'," + brandDto.IsActive + "," + brandDto.CreatedBy + ")";

            try
            {
                DataTable brandsTable = DatabaseConnection.ConnectWithServer(query);
                if (brandsTable == null)
                    return -1;

                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static int UpdateBrand(BrandDTO brandDto)
        {
            string query = "UPDATE brand SET NAME = '" + brandDto.BrandName + "', is_active = " + brandDto.IsActive +
                ", updated_by = " + brandDto.UpdatedBy + ", updated_at = '" + DateTime.Now + "' WHERE id = " + brandDto.Id;

            try
            {
                DataTable brandsTable = DatabaseConnection.ConnectWithServer(query);
                if (brandsTable == null)
                    return -1;

                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static BrandDTO GetBrandById(int brandId)
        {
            string query = "SELECT  id, name, is_active FROM brand WHERE id = " + brandId;

            try
            {
                DataTable brandsTable = DatabaseConnection.ConnectWithServer(query);
                if (brandsTable != null && brandsTable.Rows.Count > 0)
                {
                    DataRow dataRow = brandsTable.Rows[0];

                    return new BrandDTO
                    {
                        Id = int.Parse(dataRow["id"].ToString()),
                        BrandName = dataRow["name"].ToString(),
                        IsActive = (bool)dataRow["is_active"]
                    };
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static int DeleteBrand(int brandId)
        {
            string query = "Delete FROM brand WHERE id = " + brandId;
            DataTable brandsTable = DatabaseConnection.ConnectWithServer(query);
            if (brandsTable != null)
            {
                return 1;
            }
            return -1;
        }
    }
}
