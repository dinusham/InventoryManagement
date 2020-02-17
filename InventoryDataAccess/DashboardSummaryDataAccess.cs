using System;
using System.Collections.Generic;
using System.Data;
using static InventoryDataAccess.DashboardSummaryInfo;

namespace InventoryDataAccess
{
    public class DashboardSummaryDataAccess
    {
        public static List<DashboardSummaryDTO> GetDashboardSummaryList()
        {
            var summatyDtos = new List<DashboardSummaryDTO>();

            string query = string.Empty;
            foreach (string item in Enum.GetNames(typeof(DashboardType)))
            {
                switch (item)
                {
                    case "Brand":
                        query = "SELECT IF(is_active = 1, 'Active', 'Inactive') AS is_active, COUNT(*) AS total FROM brand GROUP BY is_active";
                        summatyDtos.Add(GetSummaryCount(query, item));
                        break;
                    case "Category":
                        query = "SELECT IF(is_active = 1, 'Active', 'Inactive') AS is_active, COUNT(*) AS total FROM category GROUP BY is_active";
                        summatyDtos.Add(GetSummaryCount(query, item));
                        break;
                    case "Customer":
                        query = "SELECT IF(is_active = 1, 'Active', 'Inactive') AS is_active, COUNT(*) AS total FROM customer GROUP BY is_active";
                        summatyDtos.Add(GetSummaryCount(query, item));
                        break;
                    case "Supplier":
                        query = "SELECT IF(is_active = 1, 'Active', 'Inactive') AS is_active, COUNT(*) AS total FROM supplier GROUP BY is_active";
                        summatyDtos.Add(GetSummaryCount(query, item));
                        break;
                    case "Product":
                        query = "SELECT IF(is_active = 1, 'Active', 'Inactive') AS is_active, COUNT(*) AS total FROM product GROUP BY is_active";
                        summatyDtos.Add(GetSummaryCount(query, item));
                        break;
                }
            }
            return summatyDtos;
        }

        private static DashboardSummaryDTO GetSummaryCount(string query, string itemType)
        {
            DataTable summaryTable = DatabaseConnection.ConnectWithServer(query);

            if (summaryTable != null && summaryTable.Rows.Count > 0)
            {
                int active = 0;
                int inactive = 0;

                if (summaryTable.Rows.Count == 1)
                {
                    var row = summaryTable.Rows[0];
                    if (row["is_active"].ToString() == "Inactive")
                    {
                        inactive = int.Parse(row["total"].ToString());
                        active = 0;
                    }
                    else
                    {
                        active = int.Parse(row["total"].ToString());
                        inactive = 0;
                    }
                }
                else
                {
                    foreach (DataRow row in summaryTable.Rows)
                    {
                        if (row["is_active"].ToString() == "Inactive")
                            inactive = int.Parse(row["total"].ToString());
                        else
                            active = int.Parse(row["total"].ToString());
                    }
                }

                return new DashboardSummaryDTO
                {
                    Type = itemType,
                    ActiveCount = active,
                    InActiveCount = inactive
                };
            }
            return null;
        }

        public static DataTable GetProductStockSummary()
        {
            string query = "SELECT * FROM v_product_stock";

            DataTable stocks = DatabaseConnection.ConnectWithServer(query);

            return stocks;
        }

        public static PaymentsummaryDTO GetPaymentSummary()
        {
            string query = "SELECT FORMAT(SUM(vphi.unit_price), 2) AS monthly_pay, FORMAT(SUM(vshi.unit_price), 2) AS monthly_income " +
                "FROM v_purchase_has_item vphi, v_sale_has_item vshi WHERE (vphi.created_at BETWEEN  DATE_FORMAT(NOW() ,'%Y-%m-01') " +
                "AND NOW() ) AND (vshi.created_at BETWEEN  DATE_FORMAT(NOW() ,'%Y-%m-01') AND NOW() )";

            DataTable paymentSummary = DatabaseConnection.ConnectWithServer(query);
            if (paymentSummary != null && paymentSummary.Rows.Count > 0)
            {
                DataRow dataRow = paymentSummary.Rows[0];
                return new PaymentsummaryDTO
                {
                    Pay = dataRow["monthly_pay"].ToString(),
                    Income = dataRow["monthly_income"].ToString()
                };
            }
            
            return null;
        }
    }
}
