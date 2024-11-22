namespace MX.GameLogic.DBModel
{
    public class AcademyScheduleDB
    {
        public long AccountServerId { get; set; }

        public long ScheduleUniqueId { get; set; }

        public long ScheduleGroupId { get; set; }

        public long ZoneUniqueId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public int CompleteCount { get; set; }

        public AcademyScheduleDB() { }
    }
}
