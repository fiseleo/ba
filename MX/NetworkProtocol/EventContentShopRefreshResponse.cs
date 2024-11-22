using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EventContentShopRefreshResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_ShopRefresh; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public ShopInfoDB ShopInfoDB { get; set; }

        public EventContentShopRefreshResponse() { }
    }
}
