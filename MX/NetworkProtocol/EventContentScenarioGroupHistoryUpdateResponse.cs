using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EventContentScenarioGroupHistoryUpdateResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_ScenarioGroupHistoryUpdate; }
        }

        public List<ScenarioGroupHistoryDB> ScenarioGroupHistoryDBs { get; set; }

        public List<EventContentCollectionDB> EventContentCollectionDBs { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public EventContentScenarioGroupHistoryUpdateResponse() { }
    }
}
