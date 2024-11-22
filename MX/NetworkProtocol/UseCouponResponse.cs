namespace MX.NetworkProtocol
{
    public class UseCouponResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Event_UseCoupon; }
        }

        public bool CouponCompleteRewardReceived { get; set; }

        public UseCouponResponse() { }
    }
}
