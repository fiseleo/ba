namespace MX.NetworkProtocol
{
    public class RaidRankingRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_RankingReward; }
        }

        public RaidRankingRewardRequest() { }
    }
}
