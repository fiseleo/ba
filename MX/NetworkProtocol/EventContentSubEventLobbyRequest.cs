namespace MX.NetworkProtocol
{
    public class EventContentSubEventLobbyRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_SubEventLobby; }
        }

        public long EventContentId { get; set; }

        public EventContentSubEventLobbyRequest() { }
    }
}
