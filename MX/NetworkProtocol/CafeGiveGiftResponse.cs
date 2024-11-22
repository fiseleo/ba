using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class CafeGiveGiftResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_GiveGift; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public ConsumeResultDB ConsumeResultDB { get; set; }

        public CafeGiveGiftResponse() { }
    }
}
