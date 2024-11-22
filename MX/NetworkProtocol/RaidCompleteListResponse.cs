using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    [Obsolete("MultiRaid")]
    public class RaidCompleteListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_CompleteList; }
        }

        public List<RaidDB> RaidDBs { get; set; }

        public long StackedDamage { get; set; }

        public List<long> ReceiveRewardId { get; set; }

        public long CurSeasonUniqueId { get; set; }

        public RaidCompleteListResponse() { }
    }
}
