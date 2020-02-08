using System;
using System.Data;

namespace InventoryDataAccess
{
    public class ProductDataAccess
    {
        public static DataTable GetProducts()
        {
            string query = "SELECT p.id, p.name As Name, p.title AS Title, IF(p.is_active = 1, 'Active', 'Inactive') AS Status, " +
                "c.name AS Category FROM product p, category c WHERE p.category_id = c.id";

            DataTable productTable = DatabaseConnection.ConnectWithServer(query);

            return productTable;
        }

        public static int AddProduct(ProductDTO productDto)
        {
            string query = "INSERT INTO product (name, code, title, created_by, category_id) VALUES " +
                "( " +  "'" + productDto.ProductName + "','" + productDto.ProductCode + "','" + productDto.ProductTitle + "'," + 
                productDto.CreatedBy + "," + productDto.CategoryId + ")";

            try
            {
                DataTable productTable = DatabaseConnection.ConnectWithServer(query);
                if (productTable == null)
                    return -1;

                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static int UpdateProduct(ProductDTO productDto)
        {
            string query = "UPDATE product SET name = '" + productDto.ProductName + "'" + ", code = '" + productDto.ProductCode + "', title = '" + 
                productDto.ProductTitle + "', category_id = " + productDto.CategoryId + ", is_active = " + productDto.IsActive + ", updated_by = " + 
                productDto.UpdatedBy + ", updated_at = '" + DateTime.Now + "' WHERE id = " + productDto.Id;

            try
            {
                DataTable productTable = DatabaseConnection.ConnectWithServer(query);
                if (productTable == null)
                    return -1;

                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static ProductDTO GetProductById(int productId)
        {
            string query = "SELECT id, category_id, name, title, code, is_active FROM product WHERE id = " + productId;

            try
            {
                DataTable productTable = DatabaseConnection.ConnectWithServer(query);
                if (productTable != null && productTable.Rows.Count > 0)
                {
                    DataRow dataRow = productTable.Rows[0];

                    return new ProductDTO
                    {
                        Id = int.Parse(dataRow["id"].ToString()),
                        ProductName = dataRow["name"].ToString(),
                        ProductCode = dataRow["code"].ToString(),
                        ProductTitle = dataRow["title"].ToString(),
                        CategoryId = int.Parse(dataRow["category_id"].ToString()),
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

        public static int DeleteProduct(int brandId)
        {
            string query = "Delete FROM product WHERE id = " + brandId;
            DataTable productTable = DatabaseConnection.ConnectWithServer(query);
            if (productTable != null)
            {
                return 1;
            }
            return -1;
        }
    }
}
