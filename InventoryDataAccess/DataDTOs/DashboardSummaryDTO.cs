namespace InventoryDataAccess
{
    public class DashboardSummaryDTO
    {
        public string Type { get; set; }
        public int ActiveCount { get; set; }
        public int InActiveCount { get; set; }
    }

    public class PaymentsummaryDTO
    {
        public string Pay { get; set; }
        public string Income { get; set; }
    }
}