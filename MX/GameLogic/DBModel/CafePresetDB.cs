namespace MX.GameLogic.DBModel
{
    public class CafePresetDB
    {
        public long ServerId { get; set; }

        public int SlotId { get; set; }

        public string PresetName { get; set; }

        public bool IsEmpty { get; set; }

        public CafePresetDB() { }
    }
}
