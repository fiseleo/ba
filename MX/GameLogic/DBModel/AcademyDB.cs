using System.Collections.Generic;

namespace MX.GameLogic.DBModel
{
    public class AcademyDB
    {
        public long AccountId { get; set; }

        public DateTime LastUpdate { get; set; }

        public Dictionary<long, List<VisitingCharacterDB>> ZoneVisitCharacterDBs { get; set; } = [];

        public bool ShouldSerializeZoneVisitCharacterDBs()
        {
            return ZoneVisitCharacterDBs.Count > 0;
        }

        public Dictionary<long, List<long>> ZoneScheduleGroupRecords { get; set; } = [];

        public bool ShouldSerializeZoneScheduleGroupRecords()
        {
            return ZoneScheduleGroupRecords.Count > 0;
        }

        public AcademyDB() { }
    }
}
