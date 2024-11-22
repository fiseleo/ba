namespace MX.GameLogic.DBModel
{
    public class AcademyMessageOutLineDB
    {
        public long CharacterUniqueId { get; set; }

        public long NewMessageCount { get; set; }

        public long LastMessageUniqueId { get; set; }

        public long LastMessageServerId { get; set; }

        public AcademyMessageOutLineDB() { }
    }
}
