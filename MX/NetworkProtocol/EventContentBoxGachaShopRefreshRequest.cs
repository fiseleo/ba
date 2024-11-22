namespace MX.NetworkProtocol
{
    public class EventContentBoxGachaShopRefreshRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_BoxGachaShopRefresh; }
        }

        public long EventContentId { get; set; }

        public EventContentBoxGachaShopRefreshRequest() { }
    }
}
