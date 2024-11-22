namespace MX.NetworkProtocol
{
    public class EventContentShopBuyMerchandiseRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_ShopBuyMerchandise; }
        }

        public long EventContentId { get; set; }

        public bool IsRefreshMerchandise { get; set; }

        public long ShopUniqueId { get; set; }

        public long GoodsUniqueId { get; set; }

        public long PurchaseCount { get; set; }

        public EventContentShopBuyMerchandiseRequest() { }
    }
}
