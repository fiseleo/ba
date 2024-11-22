namespace MX.NetworkProtocol
{
    public class ErrorPacket : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Error; }
        }

        public string Reason { get; set; }

        public WebAPIErrorCode ErrorCode { get; set; }

        public ErrorPacket() { }
    }
}
