namespace MX.GameLogic.DBModel
{
    public class ShopFreeRecruitHistoryDB
    {
        public long UniqueId { get; set; }

        public int RecruitCount { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public ShopFreeRecruitHistoryDB() { }
    }
}
