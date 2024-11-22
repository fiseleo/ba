using System.Collections.Generic;
using FlatData;

namespace MX.NetworkProtocol
{
    public class EventContentShopListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_ShopList; }
        }

        public long EventContentId { get; set; }

        public List<ShopCategoryType> CategoryList { get; set; }

        public EventContentShopListRequest() { }
    }
}
