namespace PurchaseOrder
{
    internal class PurchaseOrderInfo
    {
        public enum PayType
        {
            Cash = 1,
            Credit,
            Instalment,
            Other
        }

        public enum StockStatus
        {
            Available = 1,
            Finish
        }
    }
}
