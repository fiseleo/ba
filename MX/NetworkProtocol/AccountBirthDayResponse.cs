using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class AccountBirthDayResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_BirthDay; }
        }

        public AccountDB AccountDB { get; set; }

        public AccountBirthDayResponse() { }
    }
}
