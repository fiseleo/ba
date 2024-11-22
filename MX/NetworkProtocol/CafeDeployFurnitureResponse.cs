using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CafeDeployFurnitureResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_Deploy; }
        }

        public CafeDB CafeDB { get; set; }

        public long NewFurnitureServerId { get; set; }

        public List<FurnitureDB> ChangedFurnitureDBs { get; set; }

        public CafeDeployFurnitureResponse() { }
    }
}
