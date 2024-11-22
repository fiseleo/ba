namespace MX.NetworkProtocol
{
    public class EventContentCollectionListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_CollectionList; }
        }

        public long EventContentId { get; set; }

        public long? GroupId { get; set; }

        public EventContentCollectionListRequest() { }
    }
}
