using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    [Obsolete("MultiRaid")]
    public class RaidSearchResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_Search; }
        }

        public List<RaidDB> RaidDBs { get; set; }

        public RaidSearchResponse() { }
    }
}
