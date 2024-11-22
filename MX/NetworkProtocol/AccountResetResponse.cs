namespace MX.NetworkProtocol
{
    public class AccountResetResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_Reset; }
        }

        public AccountResetResponse() { }
    }
}
