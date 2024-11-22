namespace MX.NetworkProtocol
{
    public class AccountGetTutorialRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_GetTutorial; }
        }

        public AccountGetTutorialRequest() { }
    }
}
