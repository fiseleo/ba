namespace MX.NetworkProtocol
{
    public class ShopBeforehandGachaPickRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Shop_BeforehandGachaPick; }
        }

        public long ShopUniqueId { get; set; }

        public long GoodsId { get; set; }

        public long TargetIndex { get; set; }

        public ShopBeforehandGachaPickRequest() { }
    }
}
