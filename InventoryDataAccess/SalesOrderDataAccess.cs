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

        public static int AddSalesOrder(SalesOrderDTO salesOrderDto)
        {
            string query = "INSERT INTO sale_order (customer_id, discription, total_price, discount, date, pay_type, is_paid," +
                "paid_at, status, created_by) VALUES " +
                "( " +  "" + salesOrderDto.Customer + ",'" + salesOrderDto.Description + "'," + salesOrderDto.Price + "," + 
                salesOrderDto.Discount/100 + ",'" + salesOrderDto.SalesOrderDate + "'," + salesOrderDto.PayType + 
                "," + salesOrderDto.IsPaid + ",'" + DateTime.Now + "'," + salesOrderDto.SalesStatus + "," + salesOrderDto.CreatedBy + ")";

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

        public static int UpdateSalesOrder(SalesOrderDTO salesOrderDto)
        {
            string query = "UPDATE sale_order SET customer_id = " + salesOrderDto.Customer + "" + ", discription = '" + salesOrderDto.Description + "', total_price = " + 
                salesOrderDto.Price + ", discount = " + salesOrderDto.Discount/100 + ", date = '" + salesOrderDto.SalesOrderDate + "', pay_type = " + 
                salesOrderDto.PayType + ", is_paid = " + salesOrderDto.IsPaid + ", paid_at = '" + salesOrderDto.PaidDate + 
                "', status = " + salesOrderDto.SalesStatus + ", update_by = " + salesOrderDto.UpdatedBy + ", update_at = '" + DateTime.Now + "' WHERE id = " + salesOrderDto.Id;

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
                        SalesOrderDate = Convert.ToDateTime(dataRow["date"].ToString()),
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
