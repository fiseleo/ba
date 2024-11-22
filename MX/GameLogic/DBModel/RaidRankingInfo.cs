namespace MX.GameLogic.DBModel
{
    public class RaidRankingInfo
    {
        public long SeasonId { get; set; }

        public long AccountId { get; set; }

        public long Ranking { get; set; }

        public long Score { get; set; }

        public double ScoreDetail { get; set; }

        public RaidRankingInfo() { }
    }
}
