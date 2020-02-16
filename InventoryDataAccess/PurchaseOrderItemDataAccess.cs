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

            DataTable orderItemTable = DatabaseConnection.ConnectWithServer(query);

            return orderItemTable;
        }

        public static int AddOrderItems(PurchaseOrderDTO purchaseOrderDto)
        {
            string query = "INSERT INTO purchase_order (supplier_id, discription, total_price, discount, date, pay_type, is_paid," +
                "paid_at, status, created_by) VALUES " +
                "( " +  "" + purchaseOrderDto.Supplier + ",'" + purchaseOrderDto.Description + "'," + purchaseOrderDto.Price + "," + 
                purchaseOrderDto.Discount/100 + ",'" + purchaseOrderDto.OrderDate + "'," + purchaseOrderDto.PayType + 
                "," + purchaseOrderDto.IsPaid + ",'" + DateTime.Now + "'," + purchaseOrderDto.StockStatus + "," + purchaseOrderDto.CreatedBy + ")";

            try
            {
                DataTable orderItemTable = DatabaseConnection.ConnectWithServer(query);
                if (orderItemTable == null)
                    return -1;

                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static int UpdateOrderItems(PurchaseOrderDTO purchaseOrderDto)
        {
            string query = "UPDATE purchase_order SET supplier_id = " + purchaseOrderDto.Supplier + "" + ", discription = '" + purchaseOrderDto.Description + "', total_price = " + 
                purchaseOrderDto.Price + ", discount = " + purchaseOrderDto.Discount/100 + ", date = '" + purchaseOrderDto.OrderDate + "', pay_type = " + 
                purchaseOrderDto.PayType + ", is_paid = " + purchaseOrderDto.IsPaid + ", paid_at = '" + purchaseOrderDto.PaidDate + 
                "', status = " + purchaseOrderDto.StockStatus + ", update_by = " + purchaseOrderDto.UpdatedBy + ", update_at = '" + DateTime.Now + "' WHERE id = " + purchaseOrderDto.Id;

            try
            {
                DataTable orderItemTable = DatabaseConnection.ConnectWithServer(query);
                if (orderItemTable == null)
                    return -1;

                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static PurchaseOrderDTO GetOrderItemsById(int orderId)
        {
            string query = "SELECT id, discription, total_price, discount, Date, pay_type, is_paid, paid_at, status, " +
                "supplier_id FROM purchase_order WHERE id = " + orderId;

            try
            {
                DataTable orderItemTable = DatabaseConnection.ConnectWithServer(query);
                if (orderItemTable != null && orderItemTable.Rows.Count > 0)
                {
                    DataRow dataRow = orderItemTable.Rows[0];

                    return new PurchaseOrderDTO
                    {
                        Id = int.Parse(dataRow["id"].ToString()),
                        Description = dataRow["discription"].ToString(),
                        Price = Convert.ToDecimal(dataRow["total_price"].ToString()),
                        Discount = Convert.ToDecimal(dataRow["discount"].ToString()),
                        PayType = int.Parse(dataRow["pay_type"].ToString()),
                        OrderDate = Convert.ToDateTime(dataRow["date"].ToString()),
                        IsPaid = (dataRow["is_paid"].ToString() == "1") ? true : false,
                        PaidDate = Convert.ToDateTime(dataRow["paid_at"].ToString()),
                        StockStatus = int.Parse(dataRow["status"].ToString()),
                        Supplier = int.Parse(dataRow["supplier_id"].ToString())
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
            string query = "Delete FROM purchase_order WHERE id = " + orderId;
            DataTable orderItemTable = DatabaseConnection.ConnectWithServer(query);
            if (orderItemTable != null)
            {
                return 1;
            }
            return -1;
        }
    }
}
