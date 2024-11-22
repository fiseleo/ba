using System.Collections.Generic;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EliminateRaidSeasonRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EliminateRaid_SeasonReward; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public List<long> ReceiveRewardIds { get; set; }

        public EliminateRaidSeasonRewardResponse() { }
    }
}
