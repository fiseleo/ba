using System.Collections.Generic;

namespace MX.GameLogic.DBModel
{
    public class EventContentTreasureBoardHistory
    {
        public List<long> TreasureIds { get; private set; }

        public List<EventContentTreasureCell> NormalCells { get; private set; }

        public List<EventContentTreasureObject> Treasures { get; private set; }

        public EventContentTreasureBoardHistory() { }

        public bool Flip(int posX, int posY, EventContentTreasureObject metaTreasure)
        {
            return default(bool);
        }

        public bool ReceiveTreasure(long eventContentId, int round, long rewardId)
        {
            return default(bool);
        }
    }
}
