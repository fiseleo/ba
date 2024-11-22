using System.Collections.Generic;

namespace MX.GameLogic.DBModel
{
    public class WorldRaidSnapshot
    {
        public List<WorldRaidLocalBossDB> WorldRaidLocalBossDBs { get; set; }

        public List<WorldRaidClearHistoryDB> WorldRaidClearHistoryDBs { get; set; }

        public WorldRaidSnapshot(
            IEnumerable<WorldRaidLocalBossDB> worldRaidLocalBossDBs,
            IEnumerable<WorldRaidClearHistoryDB> worldRaidClearHistoryDBs
        ) { }
    }
}
