namespace MX.NetworkProtocol
{
    public class AccountPassCheckResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_PassCheck; }
        }

        public AccountPassCheckResponse() { }
    }
}
