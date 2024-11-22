using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EventContentBoxGachaShopRefreshResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_BoxGachaShopRefresh; }
        }

        public EventContentBoxGachaDB BoxGachaDB { get; set; }

        public Dictionary<long, long> BoxGachaGroupIdByCount { get; set; }

        public EventContentBoxGachaShopRefreshResponse() { }
    }
}
