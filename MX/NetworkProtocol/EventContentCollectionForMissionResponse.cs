using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EventContentCollectionForMissionResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_CollectionForMission; }
        }

        public List<EventContentCollectionDB> EventContentCollectionDBs { get; set; }

        public EventContentCollectionForMissionResponse() { }
    }
}
