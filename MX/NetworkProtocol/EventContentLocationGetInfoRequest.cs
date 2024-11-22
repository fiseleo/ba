namespace MX.NetworkProtocol
{
    public class EventContentLocationGetInfoRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_LocationGetInfo; }
        }

        public long EventContentId { get; set; }

        public EventContentLocationGetInfoRequest() { }
    }
}
