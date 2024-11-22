using System.Collections.Generic;

namespace MX.NetworkProtocol
{
    public class CafeRemoveFurnitureRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_Remove; }
        }

        public long CafeDBId { get; set; }

        public List<long> FurnitureServerIds { get; set; }

        public CafeRemoveFurnitureRequest() { }
    }
}
