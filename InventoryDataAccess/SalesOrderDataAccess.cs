using System;
using System.Collections.Generic;
using System.Data;

namespace InventoryDataAccess
{
    public class SalesOrderDataAccess
    {
        public static DataTable GetSalesOrders()
        {
            string query = "SELECT id, discription AS Description, price AS Price, discount AS Discount, discount_price AS DiscountPrice, " +
                "total AS Total, pay_type AS PayType, is_paid AS PaidStatus, paid_at AS PaidDate, order_status AS Status, " +
                "customer AS Supplier, contact AS Contact, created AS CreatedBy, created_at AS CreatedDate FROM v_sale_order ORDER By id DESC";

            DataTable salesOrdrTable = DatabaseConnection.ConnectWithServer(query);

            return salesOrdrTable;
        }

        public static int AddSalesOrder(PurchaseOrderDTO purchaseOrderDto)
        {
            string query = "INSERT INTO purchase_order (supplier_id, discription, total_price, discount, date, pay_type, is_paid," +
                "paid_at, status, created_by) VALUES " +
                "( " +  "" + purchaseOrderDto.Supplier + ",'" + purchaseOrderDto.Description + "'," + purchaseOrderDto.Price + "," + 
                purchaseOrderDto.Discount/100 + ",'" + purchaseOrderDto.OrderDate + "'," + purchaseOrderDto.PayType + 
                "," + purchaseOrderDto.IsPaid + ",'" + DateTime.Now + "'," + purchaseOrderDto.StockStatus + "," + purchaseOrderDto.CreatedBy + ")";

            try
            {
                DataTable salesOrdrTable = DatabaseConnection.ConnectWithServer(query);
                if (salesOrdrTable == null)
                    return -1;

                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static int UpdateSalesOrder(PurchaseOrderDTO purchaseOrderDto)
        {
            string query = "UPDATE purchase_order SET supplier_id = " + purchaseOrderDto.Supplier + "" + ", discription = '" + purchaseOrderDto.Description + "', total_price = " + 
                purchaseOrderDto.Price + ", discount = " + purchaseOrderDto.Discount/100 + ", date = '" + purchaseOrderDto.OrderDate + "', pay_type = " + 
                purchaseOrderDto.PayType + ", is_paid = " + purchaseOrderDto.IsPaid + ", paid_at = '" + purchaseOrderDto.PaidDate + 
                "', status = " + purchaseOrderDto.StockStatus + ", update_by = " + purchaseOrderDto.UpdatedBy + ", update_at = '" + DateTime.Now + "' WHERE id = " + purchaseOrderDto.Id;

            try
            {
                DataTable salesOrdrTable = DatabaseConnection.ConnectWithServer(query);
                if (salesOrdrTable == null)
                    return -1;

                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static SalesOrderDTO GetSalesOrderById(int orderId)
        {
            string query = "SELECT id, discription, total_price, discount, Date, pay_type, is_paid, paid_at, status, " +
                "customer_id FROM sale_order WHERE id = " + orderId;

            try
            {
                DataTable salesOrdrTable = DatabaseConnection.ConnectWithServer(query);
                if (salesOrdrTable != null && salesOrdrTable.Rows.Count > 0)
                {
                    DataRow dataRow = salesOrdrTable.Rows[0];

                    return new SalesOrderDTO
                    {
                        Id = int.Parse(dataRow["id"].ToString()),
                        Description = dataRow["discription"].ToString(),
                        Price = Convert.ToDecimal(dataRow["total_price"].ToString()),
                        Discount = Convert.ToDecimal(dataRow["discount"].ToString()),
                        PayType = int.Parse(dataRow["pay_type"].ToString()),
                        Date = Convert.ToDateTime(dataRow["date"].ToString()),
                        IsPaid = (dataRow["is_paid"].ToString() == "1") ? true : false,
                        PaidDate = Convert.ToDateTime(dataRow["paid_at"].ToString()),
                        SalesStatus = int.Parse(dataRow["status"].ToString()),
                        Customer = int.Parse(dataRow["customer_id"].ToString())
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static int DeleteSalesOrder(int orderId)
        {
            string query = "Delete FROM purchase_order WHERE id = " + orderId;
            DataTable salesOrdrTable = DatabaseConnection.ConnectWithServer(query);
            if (salesOrdrTable != null)
            {
                return 1;
            }
            return -1;
        }
    }
}
