using System.Collections.Generic;
using MX.GameLogic.Parcel;

namespace MX.GameLogic.DBModel
{
    public class MultiSweepPresetDB
    {
        public long PresetId { get; set; }

        public string PresetName { get; set; }

        public IEnumerable<long> StageIds { get; set; }

        public IEnumerable<ParcelKeyPair> ParcelIds { get; set; }

        public MultiSweepPresetDB() { }
    }
}
