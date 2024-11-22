using System.Collections.Generic;

namespace MX.GameLogic.DBModel
{
    public class EliminateRaidLobbyInfoDB : RaidLobbyInfoDB
    {
        public List<string> OpenedBossGroups { get; set; }

        public Dictionary<string, long> BestRankingPointPerBossGroup { get; set; }

        public EliminateRaidLobbyInfoDB() { }
    }
}
