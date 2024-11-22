using System.Collections.Generic;

namespace MX.GameLogic.DBModel
{
    public class EventContentBoxGachaData
    {
        public long EventContentId { get; set; }

        public Dictionary<long, EventContentBoxGachaVariation> Variations { get; set; }

        public EventContentBoxGachaData(
            long eventContentId,
            IEnumerable<EventContentBoxGachaVariation> variations
        ) { }
    }
}
