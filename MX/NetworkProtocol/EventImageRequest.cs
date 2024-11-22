namespace MX.NetworkProtocol
{
    public class EventImageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Event_GetImage; }
        }

        public long EventId { get; set; }

        public EventImageRequest() { }
    }
}
