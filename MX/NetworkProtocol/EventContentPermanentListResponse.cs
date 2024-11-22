using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EventContentPermanentListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_PermanentList; }
        }

        public List<EventContentPermanentDB> PermanentDBs { get; set; }

        public EventContentPermanentListResponse() { }
    }
}
