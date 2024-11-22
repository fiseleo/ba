namespace MX.NetworkProtocol
{
    public class AccountCallNameRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_CallName; }
        }

        public string CallName { get; set; }

        public AccountCallNameRequest() { }
    }
}
