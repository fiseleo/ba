namespace MX.NetworkProtocol
{
    public class EventContentTreasureLobbyRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_TreasureLobby; }
        }

        public long EventContentId { get; set; }

        public EventContentTreasureLobbyRequest() { }
    }
}
