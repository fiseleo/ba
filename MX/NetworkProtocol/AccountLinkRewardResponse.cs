namespace MX.NetworkProtocol
{
    public class AccountLinkRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_LinkReward; }
        }

        public AccountLinkRewardResponse() { }
    }
}
