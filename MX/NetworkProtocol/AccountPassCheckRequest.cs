namespace MX.NetworkProtocol
{
    public class AccountPassCheckRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_PassCheck; }
        }

        public string DevId { get; set; }

        public bool OnlyAccountId { get; set; }

        public AccountPassCheckRequest() { }
    }
}
