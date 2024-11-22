using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EventContentTreasureNextRoundResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_TreasureNextRound; }
        }

        public EventContentTreasureHistoryDB BoardHistoryDB { get; set; }

        public EventContentTreasureCell HiddenImage { get; set; }

        public EventContentTreasureNextRoundResponse() { }
    }
}
