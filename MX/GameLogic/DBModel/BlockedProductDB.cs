namespace MX.GameLogic.DBModel
{
    public class BlockedProductDB
    {
        public long CashProductId { get; set; }

        public ShopCashBlockType MarketBlockType
        {
            get { return (ShopCashBlockType)0L; }
        }

        public DateTime BeginDate { get; set; }

        public DateTime EndDate { get; set; }

        public BlockedProductDB() { }
    }
}
