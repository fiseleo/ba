using System.Collections.Generic;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class RaidSeasonRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_SeasonReward; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public List<long> ReceiveRewardIds { get; set; }

        public RaidSeasonRewardResponse() { }
    }
}
