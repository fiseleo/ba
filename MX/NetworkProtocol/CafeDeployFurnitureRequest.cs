using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CafeDeployFurnitureRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_Deploy; }
        }

        public long CafeDBId { get; set; }

        public FurnitureDB FurnitureDB { get; set; }

        public CafeDeployFurnitureRequest() { }
    }
}
