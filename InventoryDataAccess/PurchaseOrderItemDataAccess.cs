using System;
using System.Data;

namespace InventoryDataAccess
{
    public class PurchaseOrderItemDataAccess
    {
        public static DataTable GetOrderItems(int orderId)
        {
            string query = "SELECT id, purchase_id, product AS Product, p_code AS ProductCode, brand AS Brand, " +
                "qty AS Quantity, unit_price AS UnitPrice, total AS Total, created AS CreatedBy, " +
                "created_at AS CreatedDate FROM v_purchase_has_item WHERE purchase_id = " + orderId;

            DataTable purchaseItemTable = DatabaseConnection.ConnectWithServer(query);

            return purchaseItemTable;
        }

        public static int AddOrderItems(PurchaseItemDTO purchaseItemsDto)
        {
            string query = "INSERT INTO purchase_has_item (purchase_id, product_id, brand_id, qty, unit_price, created_by) VALUES " +
                "( " +  "" + purchaseItemsDto.PurchaseId + "," + purchaseItemsDto.ProductId + "," + purchaseItemsDto.BrandId + "," + 
                purchaseItemsDto.Quntity + "," + purchaseItemsDto.Price + "," + purchaseItemsDto.CreatedBy + ")";

            try
            {
                DataTable purchaseItemTable = DatabaseConnection.ConnectWithServer(query);
                if (purchaseItemTable == null)
                    return -1;

                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static int UpdateOrderItems(PurchaseItemDTO purchaseItemDto)
        {
            string query = "UPDATE purchase_has_item SET product_id = " + purchaseItemDto.ProductId + "" + ", brand_id = " + purchaseItemDto.BrandId + ", qty = " + 
                purchaseItemDto.Quntity + ", unit_price = " + purchaseItemDto.Price + ", updated_by = " + purchaseItemDto.UpdatedBy + ", updated_at = '" + 
                DateTime.Now + "' WHERE id = " + purchaseItemDto.Id;

            try
            {
                DataTable purchaseItemTable = DatabaseConnection.ConnectWithServer(query);
                if (purchaseItemTable == null)
                    return -1;

                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static PurchaseItemDTO GetPurchaseItemsById(int itemId, int orderId)
        {
            string query = "SELECT 	id, purchase_id, product_id, brand_id, qty, unit_price FROM purchase_has_item " +
                "WHERE id = " + itemId + " AND purchase_id = " + orderId;

            try
            {
                DataTable purchaseItemTable = DatabaseConnection.ConnectWithServer(query);
                if (purchaseItemTable != null && purchaseItemTable.Rows.Count > 0)
                {
                    DataRow dataRow = purchaseItemTable.Rows[0];

                    return new PurchaseItemDTO
                    {
                        Id = int.Parse(dataRow["id"].ToString()),
                        PurchaseId = int.Parse(dataRow["purchase_id"].ToString()),
                        ProductId = int.Parse(dataRow["product_id"].ToString()),
                        BrandId = int.Parse(dataRow["brand_id"].ToString()),
                        Quntity = int.Parse(dataRow["qty"].ToString()),
                        Price = Convert.ToDecimal(dataRow["unit_price"].ToString())
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static int DeleteOrderItems(int orderId)
        {
            string query = "Delete FROM purchase_has_item WHERE id = " + orderId;
            DataTable purchaseItemTable = DatabaseConnection.ConnectWithServer(query);
            if (purchaseItemTable != null)
            {
                return 1;
            }
            return -1;
        }
    }
}
