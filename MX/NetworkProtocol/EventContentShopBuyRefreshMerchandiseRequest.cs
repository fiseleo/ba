using System.Collections.Generic;

namespace MX.NetworkProtocol
{
    public class EventContentShopBuyRefreshMerchandiseRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_ShopBuyRefreshMerchandise; }
        }

        public long EventContentId { get; set; }

        public List<long> ShopUniqueIds { get; set; }

        public EventContentShopBuyRefreshMerchandiseRequest() { }
    }
}
