using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class CraftShiftingCompleteProcessAllResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Craft_ShiftingCompleteProcessAll; }
        }

        public List<ShiftingCraftInfoDB> CraftInfoDBs { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public CraftShiftingCompleteProcessAllResponse() { }
    }
}
