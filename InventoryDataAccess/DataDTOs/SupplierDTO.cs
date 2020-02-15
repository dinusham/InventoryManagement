namespace InventoryDataAccess
{
    public class SupplierDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public int UpdatedBy { get; set; }
        public int CreatedBy { get; set; }
    }
}