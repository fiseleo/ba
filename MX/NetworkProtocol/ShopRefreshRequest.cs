using FlatData;

namespace MX.NetworkProtocol
{
    public class ShopRefreshRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Shop_Refresh; }
        }

        public ShopCategoryType ShopCategoryType { get; set; }

        public ShopRefreshRequest() { }
    }
}
