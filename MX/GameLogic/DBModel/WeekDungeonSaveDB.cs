using FlatData;

namespace MX.GameLogic.DBModel
{
    public class WeekDungeonSaveDB : ContentSaveDB
    {
        public override ContentType ContentType
        {
            get { return ContentType.None; }
        }

        public WeekDungeonType WeekDungeonType { get; set; }

        public int Seed { get; set; }

        public int Sequence { get; set; }

        public WeekDungeonSaveDB() { }
    }
}
