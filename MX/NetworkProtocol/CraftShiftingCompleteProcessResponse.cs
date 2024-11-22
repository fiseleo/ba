using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class CraftShiftingCompleteProcessResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Craft_ShiftingCompleteProcess; }
        }

        public ShiftingCraftInfoDB CraftInfoDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public CraftShiftingCompleteProcessResponse() { }
    }
}
