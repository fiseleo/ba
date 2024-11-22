using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class MissionProgressDB
    {
        [Key]
        [JsonIgnore]
        public long ServerId { get; set; }

        [JsonIgnore]
        public long AccountServerId { get; set; }

        public long MissionUniqueId { get; set; }
        public bool Complete { get; set; }
        public DateTime StartTime { get; set; }
        public Dictionary<long, long> ProgressParameters { get; set; } = [];
    }
}
