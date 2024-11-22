using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EventContentShopListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_ShopList; }
        }

        public List<ShopInfoDB> ShopInfos { get; set; }

        public List<ShopEligmaHistoryDB> ShopEligmaHistoryDBs { get; set; }

        public EventContentShopListResponse() { }
    }
}
