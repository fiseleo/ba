namespace MX.NetworkProtocol
{
    public class CafeOpenRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_Open; }
        }

        public long CafeId { get; set; }

        public CafeOpenRequest() { }
    }
}
