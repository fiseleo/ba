using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EliminateRaidRankingRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EliminateRaid_RankingReward; }
        }

        public long ReceivedRankingRewardId { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public EliminateRaidRankingRewardResponse() { }
    }
}
