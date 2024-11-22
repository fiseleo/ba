using System.Collections.Generic;
using FlatData;
using MX.Logic.Data;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class RaidDB
    {
        public RaidMemberDescription Owner { get; set; }

        public ContentType ContentType { get; set; }

        public long ServerId { get; set; }

        public long UniqueId { get; set; }

        public long SeasonId { get; set; }

        public DateTime Begin { get; set; }

        public DateTime End { get; set; }

        [JsonIgnore]
        public long OwnerAccountServerId
        {
            get { return 0L; }
        }

        [JsonIgnore]
        public string OwnerNickname
        {
            get { return null; }
        }

        public long PlayerCount { get; set; }

        [JsonIgnore]
        public string BossGroup
        {
            get { return null; }
        }

        [JsonIgnore]
        public Difficulty BossDifficulty
        {
            get { return Difficulty.Normal; }
        }

        [JsonIgnore]
        public int LastBossIndex
        {
            get { return 0; }
        }

        public List<int> Tags { get; set; }

        public string SecretCode { get; set; }

        public RaidStatus RaidState { get; set; }

        public bool IsPractice { get; set; }

        public List<RaidBossDB> RaidBossDBs { get; set; } = [];

        public bool ShouldSerializeRaidBossDBs()
        {
            return RaidBossDBs.Count > 0;
        }

        public Dictionary<long, List<long>> ParticipateCharacterServerIds { get; set; } = [];

        public bool ShouldSerializeParticipateCharacterServerIds()
        {
            return ParticipateCharacterServerIds.Count > 0;
        }

        public bool IsEnterRoom { get; set; }

        [JsonIgnore]
        public long SessionHitPoint
        {
            get { return 0L; }
        }

        private long CalcBossSessionHitPoint()
        {
            return 0L;
        }

        public long AccountLevelWhenCreateDB { get; set; }

        public bool ClanAssistUsed { get; set; }

        public RaidDB() { }
    }
}
