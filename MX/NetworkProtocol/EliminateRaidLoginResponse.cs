using System.Collections.Generic;
using FlatData;

namespace MX.NetworkProtocol
{
    public class EliminateRaidLoginResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EliminateRaid_Login; }
        }

        public RaidSeasonType SeasonType { get; set; }

        public bool CanReceiveRankingReward { get; set; }

        public List<long> ReceiveLimitedRewardIds { get; set; }

        public Dictionary<long, long> SweepPointByRaidUniqueId { get; set; }

        public long LastSettledRanking { get; set; }

        public int? LastSettledTier { get; set; }

        public EliminateRaidLoginResponse() { }
    }
}
