namespace MX.GameLogic.DBModel
{
    public class MomoTalkChoiceDB
    {
        public long CharacterDBId { get; set; }

        public long MessageGroupId { get; set; }

        public long ChosenMessageId { get; set; }

        public DateTime ChosenDate { get; set; }

        public MomoTalkChoiceDB() { }
    }
}
