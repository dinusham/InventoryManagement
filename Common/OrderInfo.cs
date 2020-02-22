namespace Common
{
    public class OrderInfo
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