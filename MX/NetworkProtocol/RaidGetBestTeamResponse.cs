using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class RaidGetBestTeamResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_GetBestTeam; }
        }

        public List<RaidTeamSettingDB> RaidTeamSettingDBs { get; set; }

        public RaidGetBestTeamResponse() { }
    }
}
