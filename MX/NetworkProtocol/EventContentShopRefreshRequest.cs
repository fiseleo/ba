using FlatData;

namespace MX.NetworkProtocol
{
    public class EventContentShopRefreshRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_ShopRefresh; }
        }

        public long EventContentId { get; set; }

        public ShopCategoryType ShopCategoryType { get; set; }

        public EventContentShopRefreshRequest() { }
    }
}
