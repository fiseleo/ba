using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class MissionRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Mission_Reward; }
        }

        public MissionHistoryDB AddedHistoryDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public MissionRewardResponse() { }
    }
}
