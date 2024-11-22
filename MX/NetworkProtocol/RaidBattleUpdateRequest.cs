using System.Collections.Generic;
using MX.Logic.Data;
using Newtonsoft.Json;

namespace MX.NetworkProtocol
{
    public class RaidBattleUpdateRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_BattleUpdate; }
        }

        public long RaidServerId { get; set; }

        public int RaidBossIndex { get; set; }

        public long CumulativeDamage { get; set; }

        public long CumulativeGroggyPoint { get; set; }

        [JsonIgnore]
        public IEnumerable<DebuffDescription> Debuffs
        {
            get { return null; }
        }

        public bool ShouldSerializeplayerDebuffs()
        {
            return playerDebuffs.Count > 0;
        }

        public void InitList(IEnumerable<DebuffDescription> debuffs) { }

        public RaidBattleUpdateRequest() { }

        [JsonProperty]
        private List<DebuffDescription> playerDebuffs = [];
    }
}
