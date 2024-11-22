namespace MX.NetworkProtocol
{
    public class MailBoxFullErrorPacket : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Error; }
        }

        public WebAPIErrorCode ErrorCode
        {
            get { return WebAPIErrorCode.MailBoxFull; }
        }

        public MailBoxFullErrorPacket() { }
    }
}
