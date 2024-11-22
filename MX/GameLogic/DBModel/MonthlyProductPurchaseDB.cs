using FlatData;

namespace MX.GameLogic.DBModel
{
    public class MonthlyProductPurchaseDB
    {
        public long ProductId { get; set; }

        public DateTime PurchaseDate { get; set; }

        public DateTime? LastDailyRewardDate { get; set; }

        public DateTime? RewardEndDate { get; set; }

        public bool IsRepurchasable(DateTime now)
        {
            return default(bool);
        }

        public ProductTagType ProductTagType
        {
            get { return ProductTagType.Monthly; }
        }

        public MonthlyProductPurchaseDB() { }
    }
}
