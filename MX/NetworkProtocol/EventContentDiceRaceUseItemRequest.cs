using FlatData;

namespace MX.NetworkProtocol
{
    public class EventContentDiceRaceUseItemRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_DiceRaceUseItem; }
        }

        public long EventContentId { get; set; }

        public EventContentDiceRaceResultType DiceRaceResultType { get; set; }

        public EventContentDiceRaceUseItemRequest() { }
    }
}
