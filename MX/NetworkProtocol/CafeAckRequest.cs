namespace MX.NetworkProtocol
{
    public class CafeAckRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_Ack; }
        }

        public long CafeDBId { get; set; }

        public CafeAckRequest() { }
    }
}
