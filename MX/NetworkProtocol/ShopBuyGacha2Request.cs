namespace MX.NetworkProtocol
{
    public class ShopBuyGacha2Request : ShopBuyGachaRequest
    {
        public override Protocol Protocol
        {
            get { return Protocol.Shop_BuyGacha2; }
        }

        public ShopBuyGacha2Request() { }
    }
}
