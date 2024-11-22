using System.Collections.Generic;

namespace MX.GameLogic.DBModel
{
    public class EventContentLocationDB
    {
        public long AccountId { get; set; }

        public long LocationId { get; set; }

        public long Rank { get; set; }

        public long Exp { get; set; }

        public long ScheduleCount { get; set; }

        public Dictionary<long, List<VisitingCharacterDB>> ZoneVisitCharacterDBs { get; set; } = [];

        public bool ShouldSerializeZoneVisitCharacterDBs()
        {
            return ZoneVisitCharacterDBs.Count > 0;
        }

        public EventContentLocationDB() { }
    }
}
