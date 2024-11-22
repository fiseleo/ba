namespace MX.NetworkProtocol
{
    public class AccountInvalidateTokenResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_InvalidateToken; }
        }

        public AccountInvalidateTokenResponse() { }
    }
}
