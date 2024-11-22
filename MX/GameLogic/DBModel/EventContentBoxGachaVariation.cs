using System.Collections.Generic;

namespace MX.GameLogic.DBModel
{
    public class EventContentBoxGachaVariation
    {
        public long EventContentId { get; set; }

        public long VariationId { get; set; }

        public Dictionary<long, EventContentBoxGachaRoundElement> GachaRoundElements { get; set; }

        public EventContentBoxGachaVariation(
            long eventContentId,
            long variationId,
            IEnumerable<EventContentBoxGachaRoundElement> eventContentBoxGachaRoundElements
        ) { }
    }
}
