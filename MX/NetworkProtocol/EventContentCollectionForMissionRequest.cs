namespace MX.NetworkProtocol
{
    public class EventContentCollectionForMissionRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_CollectionForMission; }
        }

        public long EventContentId { get; set; }

        public EventContentCollectionForMissionRequest() { }
    }
}
