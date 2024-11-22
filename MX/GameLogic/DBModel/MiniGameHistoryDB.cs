namespace MX.GameLogic.DBModel
{
    public class MiniGameHistoryDB
    {
        public long EventContentId { get; set; }

        public long UniqueId { get; set; }

        public long HighScore { get; set; }

        public long AccumulatedScore { get; set; }

        public DateTime ClearDate { get; set; }

        public bool IsFullCombo { get; set; }

        public MiniGameHistoryDB() { }
    }
}
