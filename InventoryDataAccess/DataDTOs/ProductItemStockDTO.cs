namespace InventoryDataAccess
{
    public class ProductItemStockDTO
    {
        public int ProductId { get; set; }
        public int PurchaseId { get; set; }
        public decimal UnitPrice { get; set; }
        public int BrandId { get; set; }
        public string Brand { get; set; }
        public string Product { get; set; }
        public int AvailableItemCount { get; set; }
    }
}