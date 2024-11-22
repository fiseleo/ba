namespace MX.GameLogic.DBModel
{
    public class MiniGameShootingHistoryDB
    {
        public long EventContentId { get; set; }

        public long UniqueId { get; set; }

        public long ArriveSection { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public bool IsClearToday { get; set; }

        public bool IsValid()
        {
            return default(bool);
        }

        public MiniGameShootingHistoryDB() { }
    }
}
