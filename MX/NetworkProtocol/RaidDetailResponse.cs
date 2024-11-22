using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    [Obsolete("MultiRaid")]
    public class RaidDetailResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_Detail; }
        }

        public RaidDetailDB RaidDetailDB { get; set; }

        public List<long> ParticipateCharacterServerIds { get; set; }

        public RaidDetailResponse() { }
    }
}
