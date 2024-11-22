namespace MX.NetworkProtocol
{
    public class EventContentTreasureNextRoundRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_TreasureNextRound; }
        }

        public long EventContentId { get; set; }

        public int Round { get; set; }

        public EventContentTreasureNextRoundRequest() { }
    }
}
