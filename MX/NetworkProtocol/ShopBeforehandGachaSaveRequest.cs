namespace MX.NetworkProtocol
{
    public class ShopBeforehandGachaSaveRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Shop_BeforehandGachaSave; }
        }

        public long TargetIndex { get; set; }

        public ShopBeforehandGachaSaveRequest() { }
    }
}
