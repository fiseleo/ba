namespace MX.GameLogic.DBModel
{
    public class MomoTalkOutLineDB
    {
        public long CharacterDBId { get; set; }

        public long CharacterId { get; set; }

        public long LatestMessageGroupId { get; set; }

        public long? ChosenMessageId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public MomoTalkOutLineDB() { }
    }
}
