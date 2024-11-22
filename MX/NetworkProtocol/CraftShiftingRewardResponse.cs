using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class CraftShiftingRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Craft_ShiftingReward; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public List<ShiftingCraftInfoDB> TargetCraftInfos { get; set; }

        public CraftShiftingRewardResponse() { }
    }
}
