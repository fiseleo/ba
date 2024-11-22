using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class CraftShiftingBeginProcessResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Craft_ShiftingBeginProcess; }
        }

        public ShiftingCraftInfoDB CraftInfoDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public CraftShiftingBeginProcessResponse() { }
    }
}
