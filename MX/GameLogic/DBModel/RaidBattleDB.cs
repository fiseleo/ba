using System.Collections.Generic;
using FlatData;
using MX.Data;
using MX.Logic.Data;

namespace MX.GameLogic.DBModel
{
    public class RaidBattleDB
    {
        public ContentType ContentType { get; set; }

        public long RaidUniqueId { get; set; }

        public int RaidBossIndex { get; set; }

        public long CurrentBossHP { get; set; }

        public long CurrentBossGroggy { get; set; }

        public long CurrentBossAIPhase { get; set; }

        public string BIEchelon { get; set; }

        public bool IsClear { get; set; }

        public RaidMemberCollection RaidMembers { get; set; } = [];

        public bool ShouldSerializeRaidMembers()
        {
            return RaidMembers.Count > 0;
        }

        public List<long>? SubPartsHPs { get; set; }

        public bool ShouldSerializeSubPartsHPs()
        {
            return SubPartsHPs?.Count > 0;
        }

        public RaidBattleDB() { }

        public RaidBattleDB(
            ContentType contentType,
            long raidUniqueId,
            RaidBossDB raidBossDB,
            RaidMemberDescription raidOwner
        ) { }

        public static RaidBattleDB Clone(RaidBattleDB raidBattleDB)
        {
            return null;
        }

        public RaidBattleDB Clone()
        {
            return null;
        }

        // public bool Update(long accountId, RaidBossResultCollection results, RaidData raidRepo)
        // {
        //     return default(bool);
        // }

        // public bool Update(long accountId, RaidBossResultCollection results, WorldRaidData raidRepo)
        // {
        //     return default(bool);
        // }

        private void Build(
            long accountId,
            RaidBossResultCollection results,
            long currentBossMaxHP,
            bool phaseSync
        ) { }
    }
}
