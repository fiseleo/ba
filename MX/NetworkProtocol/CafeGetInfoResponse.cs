using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CafeGetInfoResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_Get; }
        }

        public CafeDB CafeDB { get; set; }

        public List<CafeDB> CafeDBs { get; set; }

        public List<FurnitureDB> FurnitureDBs { get; set; }

        public CafeGetInfoResponse() { }
    }
}
