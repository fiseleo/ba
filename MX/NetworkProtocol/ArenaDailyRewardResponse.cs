using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class ArenaDailyRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Arena_DailyReward; }
        }

        public ParcelResultDB ParcelResult { get; set; }

        public DateTime DailyRewardActiveTime { get; set; }

        public ArenaDailyRewardResponse() { }
    }
}
