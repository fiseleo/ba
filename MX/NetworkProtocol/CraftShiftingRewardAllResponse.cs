using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class CraftShiftingRewardAllResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Craft_ShiftingRewardAll; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public List<ShiftingCraftInfoDB> CraftInfoDBs { get; set; }

        public CraftShiftingRewardAllResponse() { }
    }
}
