using System;

namespace InventoryDataAccess
{
    public class SalesOrderDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public DateTime SalesOrderDate { get; set; }
        public int PayType { get; set; }
        public bool IsPaid { get; set; }
        public DateTime? PaidDate { get; set; }
        public int SalesStatus { get; set; }
        public int Customer { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}