using System.Collections.Generic;

namespace MX.NetworkProtocol
{
    public class ShopBuyRefreshMerchandiseRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Shop_BuyRefreshMerchandise; }
        }

        public List<long> ShopUniqueIds { get; set; }

        public ShopBuyRefreshMerchandiseRequest() { }
    }
}
