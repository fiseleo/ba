using System.Collections.Generic;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EliminateRaidLimitedRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EliminateRaid_LimitedReward; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public List<long> ReceiveRewardIds { get; set; }

        public EliminateRaidLimitedRewardResponse() { }
    }
}
