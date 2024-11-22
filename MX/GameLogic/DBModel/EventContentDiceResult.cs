using System.Collections.Generic;
using MX.GameLogic.Parcel;

namespace MX.GameLogic.DBModel
{
    public class EventContentDiceResult
    {
        public int Index { get; set; }

        public int MoveAmount { get; set; }

        public List<ParcelInfo> Rewards { get; set; }

        public EventContentDiceResult() { }
    }
}
