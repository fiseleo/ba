namespace MX.NetworkProtocol
{
    public class MailCheckRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Mail_Check; }
        }

        public MailCheckRequest() { }
    }
}
