using System;
using System.Collections.Generic;
using System.Data;

namespace InventoryDataAccess
{
    public class SalesOrderItemDataAccess
    {
        public static DataTable GetSalesItems(int salesOrderId)
        {
            string query = "SELECT id, sale_id, product AS Product, p_code AS ProductCode, brand AS Brand, " +
                "qty AS Quantity, unit_price AS UnitPrice, total AS Total, created AS CreatedBy, " +
                "created_at AS CreatedDate FROM v_sale_has_item WHERE sale_id = " + salesOrderId;

            DataTable salesItemTable = DatabaseConnection.ConnectWithServer(query);

            return salesItemTable;
        }

        public static int AddSalesItems(SalesItemDTO salesItemDto)
        {
            string query = "INSERT INTO sale_has_item (sale_id, product_id, brand_id, phi_id, qty, unit_price, created_by) VALUES " +
                "( " +  "" + salesItemDto.SalesId + "," + salesItemDto.ProductId + "," + salesItemDto.BrandId + "," +
                salesItemDto.PurchaseHItemId + "," + salesItemDto.Quntity + "," + salesItemDto.Price + "," + salesItemDto.CreatedBy + ")";

            try
            {
                DataTable salesItemTable = DatabaseConnection.ConnectWithServer(query);
                if (salesItemTable == null)
                    return -1;

                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static int UpdateSalesItems(SalesItemDTO salesItemDto)
        {
            string query = "UPDATE sale_has_item SET sale_id = " + salesItemDto.SalesId +  ", phi_id = " + salesItemDto.PurchaseHItemId + ", brand_id = " + salesItemDto.BrandId + ", qty = " +
                salesItemDto.Quntity + ", unit_price = " + salesItemDto.Price + ", updated_by = " + salesItemDto.UpdatedBy + ", updated_at = '" + 
                DateTime.Now + "' WHERE id = " + salesItemDto.Id;

            try
            {
                DataTable salesItemTable = DatabaseConnection.ConnectWithServer(query);
                if (salesItemTable == null)
                    return -1;

                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static SalesItemDTO GetSalesItemsById(int itemId, int salesOrderId)
        {
            string query = "SELECT 	id, sale_id, product_id, phi_id, brand_id, qty, unit_price FROM sale_has_item " +
                "WHERE id = " + itemId + " AND sale_id = " + salesOrderId;

            try
            {
                DataTable purchaseItemTable = DatabaseConnection.ConnectWithServer(query);
                if (purchaseItemTable != null && purchaseItemTable.Rows.Count > 0)
                {
                    DataRow dataRow = purchaseItemTable.Rows[0];

                    return new SalesItemDTO
                    {
                        Id = int.Parse(dataRow["id"].ToString()),
                        SalesId = int.Parse(dataRow["sale_id"].ToString()),
                        ProductId = int.Parse(dataRow["product_id"].ToString()),
                        BrandId = int.Parse(dataRow["brand_id"].ToString()),
                        PurchaseHItemId = int.Parse(dataRow["phi_id"].ToString()),
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

        public static int DeleteSalesItem(int orderId)
        {
            string query = "Delete FROM purchase_has_item WHERE id = " + orderId;
            DataTable purchaseItemTable = DatabaseConnection.ConnectWithServer(query);
            if (purchaseItemTable != null)
            {
                return 1;
            }
            return -1;
        }

        public static List<ProductItemStockDTO> GetProductItemsForSales(int productId)
        {
            string query = "SELECT * FROM v_product_item_stock WHERE product_id =  " + productId;

            try
            {
                DataTable productItemTables = DatabaseConnection.ConnectWithServer(query);
                var productItemStockDtos = new List<ProductItemStockDTO>();

                if (productItemTables != null && productItemTables.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in productItemTables.Rows)
                    {
                        productItemStockDtos.Add(new ProductItemStockDTO
                        {
                            ProductId = int.Parse(dataRow["product_id"].ToString()),
                            PurchaseId = int.Parse(dataRow["purchase_item_id"].ToString()),
                            UnitPrice = Convert.ToDecimal(dataRow["unit_price"].ToString()),
                            BrandId = int.Parse(dataRow["brand_id"].ToString()),
                            Brand = dataRow["brand"].ToString(),
                            Product = dataRow["product"].ToString(),
                            AvailableItemCount = int.Parse(dataRow["available_item"].ToString())
                        });
                    }
                }
                return productItemStockDtos;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
