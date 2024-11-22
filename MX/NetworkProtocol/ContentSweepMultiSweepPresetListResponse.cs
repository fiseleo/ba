using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ContentSweepMultiSweepPresetListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.ContentSweep_MultiSweepPresetList; }
        }

        public IEnumerable<MultiSweepPresetDB> MultiSweepPresetDBs { get; set; }

        public ContentSweepMultiSweepPresetListResponse() { }
    }
}
