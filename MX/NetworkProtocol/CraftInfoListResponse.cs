using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CraftInfoListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Craft_List; }
        }

        public List<CraftInfoDB> CraftInfos { get; set; }

        public List<ShiftingCraftInfoDB> ShiftingCraftInfos { get; set; }

        public CraftInfoListResponse() { }
    }
}
