using System.Collections.Generic;
using FlatData;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class WeekDungeonStageHistoryDB
    {
        public long AccountServerId { get; set; }

        public long StageUniqueId { get; set; }

        public Dictionary<StarGoalType, long> StarGoalRecord { get; set; }

        [JsonIgnore]
        public bool IsCleardEver
        {
            get { return default(bool); }
        }

        public WeekDungeonStageHistoryDB() { }
    }
}
