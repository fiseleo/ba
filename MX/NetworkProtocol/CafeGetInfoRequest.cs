namespace MX.NetworkProtocol
{
    public class CafeGetInfoRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_Get; }
        }

        public long AccountServerId { get; set; }

        public CafeGetInfoRequest() { }
    }
}
