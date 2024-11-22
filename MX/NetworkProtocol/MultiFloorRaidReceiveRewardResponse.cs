using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class MultiFloorRaidReceiveRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.MultiFloorRaid_ReceiveReward; }
        }

        public MultiFloorRaidDB MultiFloorRaidDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public MultiFloorRaidReceiveRewardResponse() { }
    }
}
