namespace MX.NetworkProtocol
{
    public class AccountRequestBirthdayMailResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_RequestBirthdayMail; }
        }

        public AccountRequestBirthdayMailResponse() { }
    }
}
