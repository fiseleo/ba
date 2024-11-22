namespace MX.NetworkProtocol
{
    public class ShopBuyEligmaRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Shop_BuyEligma; }
        }

        public long GoodsUniqueId { get; set; }

        public long ShopUniqueId { get; set; }

        public long CharacterUniqueId { get; set; }

        public long PurchaseCount { get; set; }

        public ShopBuyEligmaRequest() { }
    }
}
