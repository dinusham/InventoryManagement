using System;
using System.Collections.Generic;
using System.Data;

namespace InventoryDataAccess
{
    public class DashboardSummaryDataAccess
    {
        public static List<SummaryDTO> GetDashboardSummaryList()
        {
            var summatyDtos = new List<SummaryDTO>();

            string query = "SELECT IF(is_active = 1, 'Active', 'Inactive') AS is_active, COUNT(*) AS total FROM ";
            foreach (string item in Enum.GetNames(typeof(DashboardType)))
            {
                switch (item)
                {
                    case "Brand":
                        query = "brand GROUP BY is_active";
                        summatyDtos.Add(GetSummaryCount(query, item));
                        break;
                    case "Category":
                        query = "category GROUP BY is_active";
                        summatyDtos.Add(GetSummaryCount(query, item));
                        break;
                    case "Customer":
                        query = "customer GROUP BY is_active";
                        summatyDtos.Add(GetSummaryCount(query, item));
                        break;
                    case "Supplier":
                        query = "supplier GROUP BY is_active";
                        summatyDtos.Add(GetSummaryCount(query, item));
                        break;
                    case "Product":
                        query = "product GROUP BY is_active";
                        summatyDtos.Add(GetSummaryCount(query, item));
                        break;
                }
            }
            return summatyDtos;
        }

        private static SummaryDTO GetSummaryCount(string query, string itemType)
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



                return new SummaryDTO
                {
                    Type = itemType,
                    ActiveCount = active,
                    InActiveCount = inactive
                };
            }
            return null;
        }

    }

    public class SummaryDTO
    {
        public string Type { get; set; }
        public int ActiveCount { get; set; }
        public int InActiveCount { get; set; }
    }

    public enum DashboardType
    {
        Brand,
        Category,
        Customer,
        Supplier,
        Product
    }
}
