namespace MX.NetworkProtocol
{
    public class EventContentPortalRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_Portal; }
        }

        public long EventContentId { get; set; }

        public long StageUniqueId { get; set; }

        public long EchelonEntityId { get; set; }

        public EventContentPortalRequest() { }
    }
}
