namespace MX.NetworkProtocol
{
    public class ShopBeforehandGachaRunRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Shop_BeforehandGachaRun; }
        }

        public long ShopUniqueId { get; set; }

        public long GoodsId { get; set; }

        public ShopBeforehandGachaRunRequest() { }
    }
}
