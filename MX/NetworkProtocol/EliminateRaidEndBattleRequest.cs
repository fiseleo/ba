using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.Logic.Battles.Summary;
using MX.Logic.Data;
using Newtonsoft.Json;

namespace MX.NetworkProtocol
{
    public class EliminateRaidEndBattleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EliminateRaid_EndBattle; }
        }

        public int EchelonId { get; set; }

        public long RaidServerId { get; set; }

        public bool IsPractice { get; set; }

        [JsonIgnore]
        public int LastBossIndex
        {
            get { return 0; }
        }

        [JsonIgnore]
        public IEnumerable<RaidDamage> RaidBossDamages
        {
            get { return null; }
        }

        [JsonIgnore]
        public RaidBossResultCollection RaidBossResults
        {
            get { return null; }
        }

        public BattleSummary Summary { get; set; }

        public ClanAssistUseInfo AssistUseInfo { get; set; }

        public EliminateRaidEndBattleRequest() { }
    }
}
