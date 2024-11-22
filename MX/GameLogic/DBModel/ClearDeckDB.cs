using System.Collections.Generic;
using FlatData;

namespace MX.GameLogic.DBModel
{
    public class ClearDeckDB
    {
        public List<ClearDeckCharacterDB> ClearDeckCharacterDBs { get; set; }

        public List<long> MulliganUniqueIds { get; set; }

        public long LeaderUniqueId { get; set; }

        public long TSSInteractionUniqueId { get; set; }

        public EchelonType EchelonType { get; set; }

        public long EchelonExtensionType { get; set; }

        public EchelonPresetDB ToEchelonPresetDB(int groupIndex, int index)
        {
            return null;
        }

        public ClearDeckDB() { }
    }
}
