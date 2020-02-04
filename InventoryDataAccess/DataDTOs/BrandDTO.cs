namespace InventoryDataAccess
{
    public class BrandDTO
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
