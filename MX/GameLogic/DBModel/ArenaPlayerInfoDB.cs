namespace MX.GameLogic.DBModel
{
    public class ArenaPlayerInfoDB
    {
        public long CurrentSeasonId { get; set; }

        public long PlayerGroupId { get; set; }

        public long CurrentRank { get; set; }

        public long SeasonRecord { get; set; }

        public long AllTimeRecord { get; set; }

        public long CumulativeTimeReward { get; set; }

        public DateTime TimeRewardLastUpdateTime { get; set; }

        public DateTime BattleEnterActiveTime { get; set; }

        public DateTime DailyRewardActiveTime { get; set; }

        public ArenaPlayerInfoDB() { }
    }
}
