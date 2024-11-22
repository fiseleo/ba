using System.Collections.Generic;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EventContentRetreatResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_Retreat; }
        }

        public List<long> ReleasedEchelonNumbers { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public EventContentRetreatResponse() { }
    }
}
