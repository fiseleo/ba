namespace MX.NetworkProtocol
{
    public class AccountCreateResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_Create; }
        }

        public AccountCreateResponse() { }
    }
}
