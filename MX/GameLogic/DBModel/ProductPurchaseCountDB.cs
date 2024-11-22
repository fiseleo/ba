using FlatData;

namespace MX.GameLogic.DBModel
{
    public class ProductPurchaseCountDB
    {
        public long EventContentId { get; set; }

        public long AccountId { get; set; }

        public long ShopExcelId { get; set; }

        public int PurchaseCount { get; set; }

        public DateTime LastPurchaseDate { get; set; }

        public PurchaseCountResetType PurchaseCountResetType { get; set; }

        public DateTime ResetDate { get; set; }

        public ProductPurchaseCountDB() { }
    }
}
