using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class AccountNicknameResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_Nickname; }
        }

        public AccountDB AccountDB { get; set; }

        public AccountNicknameResponse() { }
    }
}
