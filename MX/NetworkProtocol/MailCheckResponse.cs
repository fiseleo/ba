namespace MX.NetworkProtocol
{
    public class MailCheckResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Mail_Check; }
        }

        public long Count { get; set; }

        public MailCheckResponse() { }
    }
}
