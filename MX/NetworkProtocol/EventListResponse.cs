using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EventListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Event_GetList; }
        }

        public List<EventInfoDB> EventInfoDBs { get; set; }

        public EventListResponse() { }
    }
}
