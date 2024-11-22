using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CafeRemoveFurnitureResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_Remove; }
        }

        public CafeDB CafeDB { get; set; }

        public List<FurnitureDB> FurnitureDBs { get; set; }

        public CafeRemoveFurnitureResponse() { }
    }
}
