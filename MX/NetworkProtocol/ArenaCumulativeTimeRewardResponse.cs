using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class ArenaCumulativeTimeRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Arena_CumulativeTimeReward; }
        }

        public long TimeRewardAmount { get; set; }

        public DateTime TimeRewardLastUpdateTime { get; set; }

        public ParcelResultDB ParcelResult { get; set; }

        public ArenaCumulativeTimeRewardResponse() { }
    }
}
