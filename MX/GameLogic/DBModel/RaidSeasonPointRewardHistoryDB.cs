using FlatData;

namespace MX.GameLogic.DBModel
{
    public class RaidSeasonPointRewardHistoryDB
    {
        public ContentType ContentType { get; set; }

        public long AccountId { get; set; }

        public long SeasonId { get; set; }

        public long LastReceivedSeasonRewardId { get; set; }

        public DateTime SeasonRewardReceiveDate { get; set; }

        public RaidSeasonPointRewardHistoryDB() { }
    }
}
