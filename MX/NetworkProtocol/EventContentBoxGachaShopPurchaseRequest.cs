namespace MX.NetworkProtocol
{
    public class EventContentBoxGachaShopPurchaseRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_BoxGachaShopPurchase; }
        }

        public long EventContentId { get; set; }

        public long PurchaseCount { get; set; }

        public bool PurchaseAll { get; set; }

        public EventContentBoxGachaShopPurchaseRequest() { }
    }
}
