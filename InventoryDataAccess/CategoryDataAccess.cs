using System;
using System.Data;

namespace InventoryDataAccess
{
    public class CategoryDataAccess
    {
        public static DataTable GetCategories()
        {
            string query = "SELECT  id, name AS Name, is_active AS IsActive FROM category ORDER BY id";

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
                        IsActive = dataRow["is_active"].ToString() == "1" ? true : false,
                    };
                }
                return null;
            }
            catch (Exception ex)
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
                    DataTable usersTable = DatabaseConnection.ConnectWithServer(query);
                    if (usersTable != null)
                    {
                        return 1;
                    }
                }
                
            }
            return -1;
        }
    }
}
