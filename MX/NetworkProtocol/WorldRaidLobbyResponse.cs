using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class WorldRaidLobbyResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.WorldRaid_Lobby; }
        }

        public List<WorldRaidClearHistoryDB> ClearHistoryDBs { get; set; }

        public List<WorldRaidLocalBossDB> LocalBossDBs { get; set; }

        public List<WorldRaidBossGroup> BossGroups { get; set; }

        public WorldRaidLobbyResponse() { }
    }
}
