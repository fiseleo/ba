namespace MX.NetworkProtocol
{
    public class ShopBuyAPRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Shop_BuyAP; }
        }

        public long ShopUniqueId { get; set; }

        public long PurchaseCount { get; set; }

        public ShopBuyAPRequest() { }
    }
}
