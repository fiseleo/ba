using MX.GameLogic.DBModel;
using MX.Logic.BattleEntities;
using Newtonsoft.Json;

namespace MX.Logic.Battles.Summary
{
    public class GroupSummary : IEquatable<GroupSummary>
    {
        public long TeamId { get; set; }
        public EntityId LeaderEntityId { get; set; }

        [JsonIgnore]
        public long LeaderCharacterId { get; }
        public HeroSummaryCollection Heroes { get; set; }
        public HeroSummaryCollection Supporters { get; set; }

        [JsonIgnore]
        public int AliveCount { get; }
        public bool UseAutoSkill { get; set; }
        public long TSSInteractionServerId { get; set; }
        public long TSSInteractionUniqueId { get; set; }
        public Dictionary<long, AssistRelation> AssistRelations { get; set; }

        [JsonIgnore]
        public int StrikerMaxLevel { get; }

        [JsonIgnore]
        public int SupporterMaxLevel { get; }

        [JsonIgnore]
        public int StrikerMinLevel { get; }

        [JsonIgnore]
        public int SupporterMinLevel { get; }

        [JsonIgnore]
        public int MaxCharacterLevel { get; }

        [JsonIgnore]
        public int MinCharacterLevel { get; }

        [JsonIgnore]
        public long TotalDamageGivenApplied { get; }
        public SkillCostSummary SkillCostSummary { get; set; }

        public bool Equals(GroupSummary? other)
        {
            // TODO
            return TeamId == other?.TeamId;
        }
    }
}
