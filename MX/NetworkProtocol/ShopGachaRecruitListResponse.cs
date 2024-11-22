using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ShopGachaRecruitListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Shop_GachaRecruitList; }
        }

        public List<ShopRecruitDB> ShopRecruits { get; set; }

        public List<ShopFreeRecruitHistoryDB> ShopFreeRecruitHistoryDBs { get; set; }

        public ShopGachaRecruitListResponse() { }
    }
}
