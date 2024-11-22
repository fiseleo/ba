using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EliminateRaidGetBestTeamResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EliminateRaid_GetBestTeam; }
        }

        public Dictionary<string, List<RaidTeamSettingDB>> RaidTeamSettingDBsDict { get; set; }

        public EliminateRaidGetBestTeamResponse() { }
    }
}
