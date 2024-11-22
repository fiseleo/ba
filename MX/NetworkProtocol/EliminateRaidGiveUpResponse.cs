using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EliminateRaidGiveUpResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EliminateRaid_GiveUp; }
        }

        public int Tier { get; set; }

        public RaidGiveUpDB RaidGiveUpDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public EliminateRaidGiveUpResponse() { }
    }
}
