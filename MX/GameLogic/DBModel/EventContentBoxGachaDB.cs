namespace MX.GameLogic.DBModel
{
    public class EventContentBoxGachaDB
    {
        public long AccountId { get; set; }

        public long EventContentId { get; set; }

        public long Seed { get; set; }

        public long Round { get; set; }

        public int PurchaseCount { get; set; }

        public void Reset(DateTime serverTime) { }

        public EventContentBoxGachaDB() { }
    }
}
