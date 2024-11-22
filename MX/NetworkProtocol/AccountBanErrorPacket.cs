namespace MX.NetworkProtocol
{
    public class AccountBanErrorPacket : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Error; }
        }

        public WebAPIErrorCode ErrorCode
        {
            get { return WebAPIErrorCode.AccountBanned; }
        }

        public string BanReason { get; set; }

        public AccountBanErrorPacket() { }
    }
}
