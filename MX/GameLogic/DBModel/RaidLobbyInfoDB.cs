using System.Collections.Generic;
using FlatData;

namespace MX.GameLogic.DBModel
{
    public abstract class RaidLobbyInfoDB
    {
        public long SeasonId { get; set; }

        public int Tier { get; set; }

        public long Ranking { get; set; }

        public long BestRankingPoint { get; set; }

        public long TotalRankingPoint { get; set; }

        public long ReceivedRankingRewardId { get; set; }

        public bool CanReceiveRankingReward { get; set; }

        public RaidDB? PlayingRaidDB { get; set; }

        public List<long> ReceiveRewardIds { get; set; } = [];

        public List<long> ReceiveLimitedRewardIds { get; set; }

        public List<long> ParticipateCharacterServerIds { get; set; }

        public Dictionary<string, Difficulty> PlayableHighestDifficulty { get; set; }

        public Dictionary<long, long> SweepPointByRaidUniqueId { get; set; }

        public DateTime SeasonStartDate { get; set; }

        public DateTime SeasonEndDate { get; set; }

        public DateTime SettlementEndDate { get; set; }

        public long NextSeasonId { get; set; }

        public DateTime NextSeasonStartDate { get; set; }

        public DateTime NextSeasonEndDate { get; set; }

        public DateTime NextSettlementEndDate { get; set; }

        public ClanAssistUseInfo ClanAssistUseInfo { get; set; }

        public Dictionary<int, bool> RemainFailCompensation { get; set; }

        protected RaidLobbyInfoDB() { }
    }
}
