namespace MX.NetworkProtocol
{
    public class EventContentCardShopPurchaseRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_CardShopPurchase; }
        }

        public long EventContentId { get; set; }

        public int SlotNumber { get; set; }

        public EventContentCardShopPurchaseRequest() { }
    }
}
