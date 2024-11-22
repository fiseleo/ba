namespace MX.NetworkProtocol
{
    public class AccountSetTutorialResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_SetTutorial; }
        }

        public AccountSetTutorialResponse() { }
    }
}
