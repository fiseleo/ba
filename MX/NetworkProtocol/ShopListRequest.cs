using System.Collections.Generic;
using FlatData;

namespace MX.NetworkProtocol
{
    public class ShopListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Shop_List; }
        }

        public List<ShopCategoryType> CategoryList { get; set; }

        public ShopListRequest() { }
    }
}
