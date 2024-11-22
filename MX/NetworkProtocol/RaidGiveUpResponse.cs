using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class RaidGiveUpResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_GiveUp; }
        }

        public int Tier { get; set; }

        public RaidGiveUpDB RaidGiveUpDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public RaidGiveUpResponse() { }
    }
}
