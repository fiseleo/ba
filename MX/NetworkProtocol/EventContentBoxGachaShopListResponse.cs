using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EventContentBoxGachaShopListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_BoxGachaShopList; }
        }

        public EventContentBoxGachaDB BoxGachaDB { get; set; }

        public Dictionary<long, long> BoxGachaGroupIdByCount { get; set; }

        public EventContentBoxGachaShopListResponse() { }
    }
}
