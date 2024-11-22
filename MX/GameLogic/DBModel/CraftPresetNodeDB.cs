using FlatData;

namespace MX.GameLogic.DBModel
{
    public class CraftPresetNodeDB
    {
        public CraftNodeTier NodeTier { get; set; }

        public bool IsActivated { get; set; }

        public long PriortyNodeId { get; set; }

        public ConsumeRequestDB ConsumeRequestDB { get; set; }

        public CraftPresetNodeDB() { }
    }
}
