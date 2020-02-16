using System;

namespace InventoryDataAccess
{
    public class PurchaseItemDTO
    {
        public int Id { get; set; }
        public int PurchaseId { get; set; }
        public int ProductId { get; set; }
        public int BrandId { get; set; }
        public int Quntity { get; set; }
        public decimal Price { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}