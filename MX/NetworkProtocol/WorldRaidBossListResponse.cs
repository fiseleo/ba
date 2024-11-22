using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class WorldRaidBossListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.WorldRaid_BossList; }
        }

        public List<WorldRaidBossListInfoDB> BossListInfoDBs { get; set; }

        public WorldRaidBossListResponse() { }
    }
}
