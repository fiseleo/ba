using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EventContentDiceRaceUseItemResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_DiceRaceUseItem; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public EventContentDiceRaceDB DiceRaceDB { get; set; }

        public List<EventContentDiceResult> DiceResults { get; set; }

        public List<EventContentCollectionDB> EventContentCollectionDBs { get; set; }

        public EventContentDiceRaceUseItemResponse() { }
    }
}
