namespace MX.NetworkProtocol
{
    public class EventContentCardShopListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_CardShopList; }
        }

        public long EventContentId { get; set; }

        public EventContentCardShopListRequest() { }
    }
}
