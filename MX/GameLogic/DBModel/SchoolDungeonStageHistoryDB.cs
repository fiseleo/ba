using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public sealed class SchoolDungeonStageHistoryDB
    {
        public SchoolDungeonStageHistoryDB() { }

        public long AccountServerId { get; set; }

        public long StageUniqueId { get; set; }

        [JsonIgnore]
        public long BestStarRecord
        {
            get { return 0L; }
        }

        public bool[] StarFlags { get; set; }

        [JsonIgnore]
        public bool Star1Flag
        {
            get { return default(bool); }
        }

        [JsonIgnore]
        public bool Star2Flag
        {
            get { return default(bool); }
        }

        [JsonIgnore]
        public bool Star3Flag
        {
            get { return default(bool); }
        }

        [JsonIgnore]
        public bool IsClearedEver
        {
            get { return default(bool); }
        }
    }
}
