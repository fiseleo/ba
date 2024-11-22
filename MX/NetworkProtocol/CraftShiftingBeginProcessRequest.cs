using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CraftShiftingBeginProcessRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Craft_ShiftingBeginProcess; }
        }

        public long SlotId { get; set; }

        public long RecipeId { get; set; }

        public ConsumeRequestDB ConsumeRequestDB { get; set; }

        public CraftShiftingBeginProcessRequest() { }
    }
}
