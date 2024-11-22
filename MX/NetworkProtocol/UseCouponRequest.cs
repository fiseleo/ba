namespace MX.NetworkProtocol
{
    public class UseCouponRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Event_UseCoupon; }
        }

        public string CouponSerial { get; set; }

        public UseCouponRequest() { }
    }
}
