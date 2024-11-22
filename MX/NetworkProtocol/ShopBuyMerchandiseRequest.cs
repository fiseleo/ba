namespace MX.NetworkProtocol
{
    public class ShopBuyMerchandiseRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Shop_BuyMerchandise; }
        }

        public bool IsRefreshGoods { get; set; }

        public long ShopUniqueId { get; set; }

        public long GoodsId { get; set; }

        public long PurchaseCount { get; set; }

        public ShopBuyMerchandiseRequest() { }
    }
}
