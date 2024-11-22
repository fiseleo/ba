namespace MX.NetworkProtocol
{
    public class EliminateRaidRankingRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EliminateRaid_RankingReward; }
        }

        public EliminateRaidRankingRewardRequest() { }
    }
}
