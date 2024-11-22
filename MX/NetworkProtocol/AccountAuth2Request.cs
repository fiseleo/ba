namespace MX.NetworkProtocol
{
    public class AccountAuth2Request : AccountAuthRequest
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_Auth2; }
        }

        public AccountAuth2Request() { }
    }
}
