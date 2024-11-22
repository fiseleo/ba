using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    [Obsolete("MultiRaid")]
    public class RaidListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_List; }
        }

        public List<RaidDB> CreateRaidDBs { get; set; }

        public List<RaidDB> EnterRaidDBs { get; set; }

        public List<RaidDB> ListRaidDBs { get; set; }

        public RaidListResponse() { }
    }
}
