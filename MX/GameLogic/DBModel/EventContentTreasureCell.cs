using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class EventContentTreasureCell : IEquatable<EventContentTreasureCell>
    {
        [JsonProperty]
        public int X { get; private set; }

        [JsonProperty]
        public int Y { get; private set; }

        public EventContentTreasureCell(int posX, int posY) { }

        public bool Equals(EventContentTreasureCell other)
        {
            return default(bool);
        }

        public bool Equals(int x, int y)
        {
            return default(bool);
        }

        public override bool Equals(object obj)
        {
            return default(bool);
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}
