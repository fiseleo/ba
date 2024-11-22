using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CafeRemoveAllFurnitureResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_RemoveAll; }
        }

        public CafeDB CafeDB { get; set; }

        public List<FurnitureDB> FurnitureDBs { get; set; }

        public CafeRemoveAllFurnitureResponse() { }
    }
}
