namespace MX.NetworkProtocol
{
    public class AccountCheckYostarRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_CheckYostar; }
        }

        public long UID { get; set; }

        public string YostarToken { get; set; }

        public string EnterTicket { get; set; }

        public bool PassCookieResult { get; set; }

        public string Cookie { get; set; }

        public AccountCheckYostarRequest() { }
    }
}
