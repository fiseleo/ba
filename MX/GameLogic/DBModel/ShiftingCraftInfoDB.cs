namespace MX.GameLogic.DBModel
{
    public class ShiftingCraftInfoDB
    {
        public long SlotSequence { get; set; }

        public long CraftRecipeId { get; set; }

        public long CraftAmount { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public bool IsComplete(DateTime nowTime)
        {
            return default(bool);
        }

        public ShiftingCraftInfoDB() { }
    }
}
