namespace MX.NetworkProtocol
{
    public class AccountCheckYostarResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_CheckYostar; }
        }

        public int ResultState { get; set; }

        public string ResultMessag { get; set; }

        public string Birth { get; set; }

        public AccountCheckYostarResponse() { }
    }
}
