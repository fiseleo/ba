using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class RaidRankingRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_RankingReward; }
        }

        public long ReceivedRankingRewardId { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public RaidRankingRewardResponse() { }
    }
}
