using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class MissionHistoryDB
    {
        [JsonIgnore]
        public long ServerId { get; set; }

        [JsonIgnore]
        public long AccountServerId { get; set; }

        public long MissionUniqueId { get; set; }

        public DateTime CompleteTime { get; set; }

        public bool Expired { get; set; }

        public MissionHistoryDB() { }
    }
}
