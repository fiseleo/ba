using System.Collections.Generic;
using MX.Data;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class DetailedAccountInfoDB
    {
        public long AccountId { get; set; }

        public string Nickname { get; set; }

        public long Level { get; set; }

        public string ClanName { get; set; }

        public string Comment { get; set; }

        public long FriendCount { get; set; }

        public string FriendCode { get; set; }

        public long RepresentCharacterUniqueId { get; set; }

        public long CharacterCount { get; set; }

        public long? LastNormalCampaignClearStageId { get; set; }

        public long? LastHardCampaignClearStageId { get; set; }

        public long? ArenaRanking { get; set; }

        public long? RaidRanking { get; set; }

        public int? RaidTier { get; set; }

        public long? EliminateRaidRanking { get; set; }

        public int? EliminateRaidTier { get; set; }

        public AssistCharacterDB[] AssistCharacterDBs { get; set; }

        [JsonConstructor]
        public DetailedAccountInfoDB() { }

        public DetailedAccountInfoDB(
            AccountDB accountDB,
            string clanName,
            int friendCount,
            string friendCode,
            IEnumerable<CharacterDB> characterDBs,
            IEnumerable<CampaignStageInfo> clearedStageInfos,
            long? arenaRanking,
            long? raidRanking,
            int? raidTier,
            long? eliminateRaidRanking,
            int? eliminateRaidTier,
            IEnumerable<AssistCharacterDB> assistCharacterDBs
        ) { }
    }
}
