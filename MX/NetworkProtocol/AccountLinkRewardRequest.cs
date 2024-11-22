namespace MX.NetworkProtocol
{
    public class AccountLinkRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_LinkReward; }
        }

        public AccountLinkRewardRequest() { }
    }
}
