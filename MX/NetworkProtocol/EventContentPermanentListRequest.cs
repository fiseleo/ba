namespace MX.NetworkProtocol
{
    public class EventContentPermanentListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_PermanentList; }
        }

        public EventContentPermanentListRequest() { }
    }
}
