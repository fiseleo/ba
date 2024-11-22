using System.Collections.Generic;

namespace MX.GameLogic.DBModel
{
    public class WorldRaidBossListInfoDB
    {
        public long GroupId { get; set; }

        public WorldRaidWorldBossDB WorldBossDB { get; set; }

        public List<WorldRaidLocalBossDB> LocalBossDBs { get; set; }

        public WorldRaidBossListInfoDB() { }
    }
}
