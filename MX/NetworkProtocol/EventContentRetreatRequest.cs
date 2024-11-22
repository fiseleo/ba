namespace MX.NetworkProtocol
{
    public class EventContentRetreatRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_Retreat; }
        }

        public long EventContentId { get; set; }

        public long StageUniqueId { get; set; }

        public EventContentRetreatRequest() { }
    }
}
