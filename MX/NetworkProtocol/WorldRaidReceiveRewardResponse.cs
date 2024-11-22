using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class WorldRaidReceiveRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.WorldRaid_ReceiveReward; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public WorldRaidReceiveRewardResponse() { }
    }
}
