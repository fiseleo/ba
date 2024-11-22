namespace MX.GameLogic.DBModel
{
    public class GuideMissionSeasonDB
    {
        public long SeasonId { get; set; }

        public long LoginCount { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime LoginDate { get; set; }

        public bool IsComplete { get; set; }

        public bool IsFinalMissionComplete { get; set; }

        public DateTime? CollectionItemReceiveDate { get; set; }

        public GuideMissionSeasonDB() { }
    }
}
