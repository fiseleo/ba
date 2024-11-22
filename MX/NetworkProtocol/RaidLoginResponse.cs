using FlatData;

namespace MX.NetworkProtocol
{
    public class RaidLoginResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_Login; }
        }

        public RaidSeasonType SeasonType { get; set; }

        public bool CanReceiveRankingReward { get; set; }

        public long LastSettledRanking { get; set; }

        public int? LastSettledTier { get; set; }

        public RaidLoginResponse() { }
    }
}
