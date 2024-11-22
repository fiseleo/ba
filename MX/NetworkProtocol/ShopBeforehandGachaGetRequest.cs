namespace MX.NetworkProtocol
{
    public class ShopBeforehandGachaGetRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Shop_BeforehandGachaGet; }
        }

        public ShopBeforehandGachaGetRequest() { }
    }
}
