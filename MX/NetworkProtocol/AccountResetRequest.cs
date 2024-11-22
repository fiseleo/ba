namespace MX.NetworkProtocol
{
    public class AccountResetRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_Reset; }
        }

        public string DevId { get; set; }

        public AccountResetRequest() { }
    }
}
