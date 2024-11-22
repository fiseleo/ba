using System.Collections.Generic;

namespace MX.GameLogic.DBModel
{
    public class EventContentBoxGachaRoundElement
    {
        public long EventContentId { get; set; }

        public long VariationId { get; set; }

        public long Round { get; set; }

        public List<EventContentBoxGachaElement> Elements { get; set; }

        public EventContentBoxGachaRoundElement(
            long eventContentId,
            long variationId,
            long round,
            IEnumerable<EventContentBoxGachaElement> elements
        ) { }
    }
}
