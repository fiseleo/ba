namespace MX.NetworkProtocol
{
    public class EventContentCardShopPurchaseAllRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_CardShopPurchaseAll; }
        }

        public long EventContentId { get; set; }

        public EventContentCardShopPurchaseAllRequest() { }
    }
}
