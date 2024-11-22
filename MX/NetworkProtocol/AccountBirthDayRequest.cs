namespace MX.NetworkProtocol
{
    public class AccountBirthDayRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_BirthDay; }
        }

        public DateTime BirthDay { get; set; }

        public AccountBirthDayRequest() { }
    }
}
