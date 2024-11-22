using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EventContentFortuneGachaPurchaseResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_FortuneGachaPurchase; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public EventContentFortuneGachaPurchaseResponse() { }

        public long FortuneGachaShopUniqueId;
    }
}
