using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EventContentTreasureLobbyResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_TreasureLobby; }
        }

        public EventContentTreasureHistoryDB BoardHistoryDB { get; set; }

        public EventContentTreasureCell HiddenImage { get; set; }

        public long VariationId { get; set; }

        public EventContentTreasureLobbyResponse() { }
    }
}
