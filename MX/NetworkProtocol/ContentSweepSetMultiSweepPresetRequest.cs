using System.Collections.Generic;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class ContentSweepSetMultiSweepPresetRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.ContentSweep_SetMultiSweepPreset; }
        }

        public long PresetId { get; set; }

        public string PresetName { get; set; }

        public IEnumerable<long> StageIds { get; set; }

        public IEnumerable<ParcelKeyPair> ParcelIds { get; set; }

        public ContentSweepSetMultiSweepPresetRequest() { }
    }
}
