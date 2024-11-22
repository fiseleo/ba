namespace MX.GameLogic.DBModel
{
    public class EventContentCollectionDB
    {
        public long EventContentId { get; set; }

        public long GroupId { get; set; }

        public long UniqueId { get; set; }

        public DateTime ReceiveDate { get; set; }

        public EventContentCollectionDB() { }

        public EventContentCollectionDB(
            long eventContentId,
            long groupId,
            long uniqueId,
            DateTime receiveDate
        ) { }
    }
}
