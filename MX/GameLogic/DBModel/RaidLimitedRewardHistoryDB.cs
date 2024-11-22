using FlatData;

namespace MX.GameLogic.DBModel
{
    public class RaidLimitedRewardHistoryDB
    {
        public ContentType ContentType { get; set; }

        public long AccountId { get; set; }

        public long SeasonId { get; set; }

        public long RewardId { get; set; }

        public DateTime ReceiveDate { get; set; }

        public RaidLimitedRewardHistoryDB() { }
    }
}
