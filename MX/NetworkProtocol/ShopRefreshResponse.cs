using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class ShopRefreshResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Shop_Refresh; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public ShopInfoDB ShopInfoDB { get; set; }

        public ShopRefreshResponse() { }
    }
}
