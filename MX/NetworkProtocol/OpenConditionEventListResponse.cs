using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class OpenConditionEventListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.OpenCondition_EventList; }
        }

        public Dictionary<long, List<ConquestTileDB>> ConquestTiles { get; set; }

        public Dictionary<long, List<WorldRaidLocalBossDB>> WorldRaidLocalBossDBs { get; set; }

        public OpenConditionEventListResponse() { }
    }
}
