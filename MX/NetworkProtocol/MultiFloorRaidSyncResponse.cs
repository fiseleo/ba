using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class MultiFloorRaidSyncResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.MultiFloorRaid_Sync; }
        }

        public List<MultiFloorRaidDB> MultiFloorRaidDBs { get; set; }

        public MultiFloorRaidSyncResponse() { }
    }
}
