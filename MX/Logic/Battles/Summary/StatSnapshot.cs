using FlatData;
using Newtonsoft.Json;

namespace MX.Logic.Battles.Summary
{
    public class StatSnapshot
    {
        public StatType Stat { get; set; }
        public long Start { get; set; }
        public long End { get; set; }

        [JsonIgnore]
        public long Diff { get; }
    }
}
