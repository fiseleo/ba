namespace MX.NetworkProtocol
{
    public class AccountAuth2Response : AccountAuthResponse
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_Auth2; }
        }

        public AccountAuth2Response() { }
    }
}
