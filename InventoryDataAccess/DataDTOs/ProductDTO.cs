namespace InventoryDataAccess
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string ProductTitle { get; set; }
        public int CategoryId { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}