using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class AccountCallNameResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_CallName; }
        }

        public AccountDB AccountDB { get; set; }

        public AccountCallNameResponse() { }
    }
}
