namespace MX.NetworkProtocol
{
    public class AccountInvalidateTokenRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_InvalidateToken; }
        }

        public AccountInvalidateTokenRequest() { }
    }
}
