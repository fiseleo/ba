namespace MX.GameLogic.DBModel
{
    public class EventContentDiceRaceDB
    {
        public long EventContentId { get; set; }

        public long Node { get; set; }

        public long LapCount { get; set; }

        public long DiceRollCount { get; set; }

        public long ReceiveRewardLapCount { get; set; }

        public EventContentDiceRaceDB Clone()
        {
            return null;
        }

        public long GetMaxNodeIndex()
        {
            return 0L;
        }

        public bool Validate()
        {
            return default(bool);
        }

        public void Move(long moveAmount) { }

        public static EventContentDiceRaceDB CreateNewDiceRaceDB(long eventContentId)
        {
            return null;
        }

        public EventContentDiceRaceDB() { }
    }
}
