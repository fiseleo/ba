namespace MX.NetworkProtocol
{
    public class AccountRequestBirthdayMailRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_RequestBirthdayMail; }
        }

        public DateTime Birthday { get; set; }

        public AccountRequestBirthdayMailRequest() { }
    }
}
