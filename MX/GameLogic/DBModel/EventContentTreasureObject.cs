using System.Collections.Generic;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class EventContentTreasureObject
    {
        [JsonProperty(PropertyName = "Id")]
        public long ServerId { get; private set; }

        [JsonProperty]
        public long RewardId { get; private set; }

        [JsonProperty]
        public int Rotation { get; private set; }

        [JsonProperty]
        public bool IsHiddenImage { get; private set; }

        public List<EventContentTreasureCell> Cells { get; private set; }

        public EventContentTreasureObject(
            long serverId,
            long rewardId,
            int rotation,
            bool isHiddenImage,
            List<EventContentTreasureCell> cells
        ) { }

        public bool IsFoundCell(int posX, int posY)
        {
            return default(bool);
        }

        public bool IsFoundAll(IEnumerable<EventContentTreasureCell> others)
        {
            return default(bool);
        }

        public bool IsFoundAll(IEnumerable<EventContentTreasureObject> treasures)
        {
            return default(bool);
        }
    }
}
