namespace MX.NetworkProtocol
{
    public class ShopBuyGachaRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Shop_BuyGacha; }
        }

        public long GoodsId { get; set; }

        public long ShopUniqueId { get; set; }

        public ShopBuyGachaRequest() { }
    }
}
