using FlatData;

namespace MX.GameLogic.DBModel
{
    public class RaidSeasonRankingHistoryDB
    {
        public ContentType ContentType { get; set; }

        public long AccountId { get; set; }

        public long SeasonId { get; set; }

        public long Ranking { get; set; }

        public long BestRankingPoint { get; set; }

        public int Tier { get; set; }

        public DateTime ReceivedDate { get; set; }

        public RaidSeasonRankingHistoryDB() { }
    }
}
