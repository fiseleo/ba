namespace MX.GameLogic.DBModel
{
    public class AcademyMessageDB
    {
        public long MessageServerId { get; set; }

        public long MessageGroupId { get; set; }

        public long MessageUniqueId { get; set; }

        public long SelectedMessageUniqueId { get; set; }

        public long CharacterServerId { get; set; }

        public long CharacterUniqueId { get; set; }

        public bool IsRead { get; set; }

        public AcademyMessageDB() { }
    }
}
