using System.Collections.Generic;
using FlatData;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class TimeAttackDungeonBattleHistoryDB
    {
        public TimeAttackDungeonType DungeonType { get; set; }

        public long GeasId { get; set; }

        public long DefaultPoint { get; set; }

        public long ClearTimePoint { get; set; }

        public long EndFrame { get; set; }

        [JsonIgnore]
        public long TotalPoint
        {
            get { return 0L; }
        }

        public List<TimeAttackDungeonCharacterDB> MainCharacterDBs { get; set; }

        public List<TimeAttackDungeonCharacterDB> SupportCharacterDBs { get; set; }

        public TimeAttackDungeonBattleHistoryDB() { }

        public IEnumerable<long> GetCharacterDBIds()
        {
            return null;
        }

        public bool IsAssistUsed()
        {
            return default(bool);
        }

        public override string ToString()
        {
            return null;
        }
    }
}
