using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EventContentBoxGachaShopPurchaseResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_BoxGachaShopPurchase; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public EventContentBoxGachaDB BoxGachaDB { get; set; }

        public Dictionary<long, long> BoxGachaGroupIdByCount { get; set; }

        public List<EventContentBoxGachaElement> BoxGachaElements { get; set; }

        public EventContentBoxGachaShopPurchaseResponse() { }
    }
}
