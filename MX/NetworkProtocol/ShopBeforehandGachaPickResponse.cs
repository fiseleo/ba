using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ShopBeforehandGachaPickResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Shop_BeforehandGachaPick; }
        }

        public List<GachaResult> GachaResults { get; set; }

        public List<ItemDB> AcquiredItems { get; set; }

        public ShopBeforehandGachaPickResponse() { }
    }
}
