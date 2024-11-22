namespace MX.NetworkProtocol
{
    public class EventContentBoxGachaShopListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_BoxGachaShopList; }
        }

        public long EventContentId { get; set; }

        public EventContentBoxGachaShopListRequest() { }
    }
}
