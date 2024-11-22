namespace MX.NetworkProtocol
{
    public class EventContentAdventureListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_AdventureList; }
        }

        public long EventContentId { get; set; }

        public EventContentAdventureListRequest() { }
    }
}
