namespace MX.GameLogic.DBModel
{
    public class EventContentChangeDB
    {
        public long AccountId { get; set; }

        public long EventContentId { get; set; }

        public long UseAmount { get; set; }

        public long ChangeCount { get; set; }

        public long AccumulateChangeCount { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public bool ChangeFlag { get; set; }

        public EventContentChangeDB() { }
    }
}
