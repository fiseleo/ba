using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CafeOpenResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_Open; }
        }

        public CafeDB OpenedCafeDB { get; set; }

        public List<FurnitureDB> FurnitureDBs { get; set; }

        public CafeOpenResponse() { }
    }
}
