using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CafeRelocateFurnitureRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_Relocate; }
        }

        public long CafeDBId { get; set; }

        public FurnitureDB FurnitureDB { get; set; }

        public CafeRelocateFurnitureRequest() { }
    }
}
