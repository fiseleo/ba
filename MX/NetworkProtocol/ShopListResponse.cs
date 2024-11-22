using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ShopListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Shop_List; }
        }

        public List<ShopInfoDB> ShopInfos { get; set; }

        public List<ShopEligmaHistoryDB> ShopEligmaHistoryDBs { get; set; }

        public ShopListResponse() { }
    }
}
