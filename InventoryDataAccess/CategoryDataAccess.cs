using System;
using System.Collections.Generic;
using System.Data;

namespace InventoryDataAccess
{
    public class CategoryDataAccess
    {
        public static DataTable GetCategories()
        {
            string query = "SELECT  c.id, c.name AS Name, IF(c.is_active = 1, 'Active', 'Inactive') AS Status, " +
                "CONCAT(a.first_name, ' ', a.last_name) AS CreatedBy  FROM category c, admin a WHERE c.created_by = a.id";

            DataTable categories = DatabaseConnection.ConnectWithServer(query);

            return categories;
        }

        public static int AddCategory(CategoryDTO categoryDto)
        {
            string query = "INSERT INTO category (NAME, is_active, created_by) VALUES " +
                "( " +  "'" + categoryDto.CategoryName + "'," + categoryDto.IsActive + "," + categoryDto.CreatedBy + ")";

            try
            {
                DataTable categories = DatabaseConnection.ConnectWithServer(query);
                if (categories == null)
                    return -1;

                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static int UpdateCategory(CategoryDTO categoryDto)
        {
            string query = "UPDATE category SET NAME = '" + categoryDto.CategoryName + "', is_active = " + categoryDto.IsActive +
                ", updated_by = " + categoryDto.UpdatedBy + ", updated_at = '" + DateTime.Now + "' WHERE id = " + categoryDto.Id;

            try
            {
                DataTable categories = DatabaseConnection.ConnectWithServer(query);
                if (categories == null)
                    return -1;

                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static CategoryDTO GetCategoryById(int categoryId)
        {
            string query = "SELECT  id, name, is_active FROM category WHERE id = " + categoryId;

            try
            {
                DataTable categories = DatabaseConnection.ConnectWithServer(query);
                if (categories != null && categories.Rows.Count > 0)
                {
                    DataRow dataRow = categories.Rows[0];

                    return new CategoryDTO
                    {
                        Id = int.Parse(dataRow["id"].ToString()),
                        CategoryName = dataRow["name"].ToString(),
                        IsActive = (dataRow["is_active"].ToString() == "1") ? true : false
                    };
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static int DeleteCategory(int categoryId)
        {
            string productsQuery = "SELECT COUNT(*) AS count FROM product WHERE category_id = " + categoryId;
            DataTable productsTable = DatabaseConnection.ConnectWithServer(productsQuery);

            if (productsTable != null && productsTable.Rows.Count > 0)
            {
                if(int.Parse(productsTable.Rows[0]["count"].ToString()) > 0)
                {
                    string query = "UPDATE category SET is_deleted = " + true + " WHERE id = " + categoryId;

                    DataTable categoryTable = DatabaseConnection.ConnectWithServer(query);
                    if (categoryTable != null)
                    {
                        return 1;
                    }
                }
                else
                {
                    string query = "Delete FROM category WHERE id = " + categoryId;
                    DataTable categoryTable = DatabaseConnection.ConnectWithServer(query);
                    if (categoryTable != null)
                    {
                        return 1;
                    }
                }
                
            }
            return -1;
        }

        public static IDictionary<int, string> GetCategoriesForProduct()
        {
            string query = "SELECT id, name FROM category ORDER By id";

            DataTable categories = DatabaseConnection.ConnectWithServer(query);

            if (categories != null && categories.Rows.Count > 0)
            {
                var keyValues = new Dictionary<int, string>();
                foreach (DataRow row in categories.Rows)
                {
                    keyValues.Add(int.Parse(row["id"].ToString()), row["name"].ToString());
                }
                return keyValues;
            }
            return null;
        }
    }
}
