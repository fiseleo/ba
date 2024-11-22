namespace MX.NetworkProtocol
{
    public class AccountNicknameRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_Nickname; }
        }

        public string Nickname { get; set; }

        public AccountNicknameRequest() { }
    }
}
