using System.Collections.Generic;
using FlatData;

namespace MX.GameLogic.DBModel
{
    public class CraftPresetSlotDB
    {
        public List<CraftPresetNodeDB> PresetNodeDBs { get; set; }

        public ConsumeRequestDB MakeConsumeRequestDB(long count)
        {
            return null;
        }

        public CraftNodeTier GetMaxNodeTier()
        {
            return CraftNodeTier.Base;
        }

        public CraftPresetSlotDB() { }
    }
}
