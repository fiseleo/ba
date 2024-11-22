namespace MX.GameLogic.DBModel
{
    public class PurchaseCountDB
    {
        public long ShopCashId { get; set; }

        public int PurchaseCount { get; set; }

        public DateTime ResetDate { get; set; }

        public DateTime? PurchaseDate { get; set; }

        public DateTime? ManualResetDate { get; set; }

        public PurchaseCountDB() { }
    }
}
