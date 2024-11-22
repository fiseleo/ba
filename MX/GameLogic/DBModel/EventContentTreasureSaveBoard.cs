using System.Collections.Generic;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class EventContentTreasureSaveBoard
    {
        [JsonProperty]
        public long VariationId { get; private set; }

        [JsonProperty]
        public int Round { get; private set; }

        [JsonProperty(PropertyName = "Treasures")]
        public List<EventContentTreasureObject> TreasureObjects { get; private set; }

        public EventContentTreasureSaveBoard(long id, int round) { }

        // public bool IsTreasure(int posX, int posY, out EventContentTreasureObject treasure)
        // {
        //     return default(bool);
        // }
    }
}
