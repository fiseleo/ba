namespace MX.GameLogic.DBModel
{
    public class RaidSeasonHistoryDB
    {
        public long SeasonServerId { get; set; }

        public DateTime ReceiveDateTime { get; set; }

        public long SeasonRewardGauage { get; set; }

        public RaidSeasonHistoryDB() { }
    }
}
