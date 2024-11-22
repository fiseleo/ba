namespace MX.GameLogic.DBModel
{
    public class WorldRaidClearHistoryDB
    {
        public long SeasonId { get; set; }

        public long GroupId { get; set; }

        public DateTime RewardReceiveDate { get; set; }

        public WorldRaidClearHistoryDB() { }
    }
}
