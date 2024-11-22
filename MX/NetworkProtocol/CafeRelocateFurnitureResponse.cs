using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CafeRelocateFurnitureResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_Relocate; }
        }

        public CafeDB CafeDB { get; set; }

        public FurnitureDB RelocatedFurnitureDB { get; set; }

        public CafeRelocateFurnitureResponse() { }
    }
}
