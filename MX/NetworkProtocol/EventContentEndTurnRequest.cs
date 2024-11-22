namespace MX.NetworkProtocol
{
    public class EventContentEndTurnRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_EndTurn; }
        }

        public long EventContentId { get; set; }

        public long StageUniqueId { get; set; }

        public EventContentEndTurnRequest() { }
    }
}
