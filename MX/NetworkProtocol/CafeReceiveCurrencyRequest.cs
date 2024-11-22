namespace MX.NetworkProtocol
{
    public class CafeReceiveCurrencyRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_ReceiveCurrency; }
        }

        public long AccountServerId { get; set; }

        public long CafeDBId { get; set; }

        public CafeReceiveCurrencyRequest() { }
    }
}
