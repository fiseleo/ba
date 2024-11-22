namespace MX.GameLogic.DBModel
{
    public class RaidSeasonManageDB
    {
        public long SeasonId { get; set; }

        public DateTime SeasonStartDate { get; set; }

        public DateTime SeasonEndDate { get; set; }

        public DateTime SeasonSettlementEndDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public RaidSeasonManageDB() { }
    }
}
