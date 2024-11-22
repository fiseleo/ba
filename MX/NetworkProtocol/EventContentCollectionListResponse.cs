using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EventContentCollectionListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_CollectionList; }
        }

        public List<EventContentCollectionDB> EventContentUnlockCGDBs { get; set; }

        public EventContentCollectionListResponse() { }
    }
}
