using System;

namespace InventoryDataAccess
{
    public class PurchaseItemsDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public DateTime OrderDate { get; set; }
        public int PayType { get; set; }
        public bool IsPaid { get; set; }
        public DateTime? PaidDate { get; set; }
        public int StockStatus { get; set; }
        public int Supplier { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}