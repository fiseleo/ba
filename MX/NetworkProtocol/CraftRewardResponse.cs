using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class CraftRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Craft_Reward; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public List<CraftInfoDB> CraftInfos { get; set; }

        public CraftRewardResponse() { }
    }
}
