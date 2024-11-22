namespace MX.NetworkProtocol
{
    public class EliminateRaidLimitedRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EliminateRaid_LimitedReward; }
        }

        public EliminateRaidLimitedRewardRequest() { }
    }
}
