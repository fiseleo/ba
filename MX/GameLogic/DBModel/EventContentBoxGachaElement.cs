using System.Collections.Generic;
using MX.GameLogic.Parcel;

namespace MX.GameLogic.DBModel
{
    public class EventContentBoxGachaElement
    {
        public long EventContentId { get; set; }

        public long VariationId { get; set; }

        public long Round { get; set; }

        public long GroupId { get; set; }

        public long UniqueId { get; set; }

        public bool IsPrize { get; set; }

        public List<ParcelInfo> Rewards { get; set; }

        public EventContentBoxGachaElement Clone()
        {
            return null;
        }

        public EventContentBoxGachaElement() { }
    }
}
