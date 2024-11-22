using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class RaidRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_Reward; }
        }

        public long RankingPoint { get; set; }

        public long BestRankingPoint { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public RaidRewardResponse() { }
    }
}
