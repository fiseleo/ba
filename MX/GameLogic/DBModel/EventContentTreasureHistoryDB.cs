using System.Collections.Generic;
using MX.Data;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class EventContentTreasureHistoryDB
    {
        public long EventContentId { get; set; }

        public int Round { get; set; }

        public EventContentTreasureBoardHistory Board { get; set; }

        public bool IsComplete { get; set; }

        public List<EventContentTreasureObject> HintTreasures { get; set; }

        public static EventContentTreasureHistoryDB CreateTreasureHistoryDB(
            long eventContentId,
            int currentRound
        )
        {
            return null;
        }

        public void BuildHintTreasure(EventContentTreasureSaveBoard saveBoard) { }

        [JsonIgnore]
        public int MetaRound
        {
            get { return 0; }
        }

        [JsonIgnore]
        public bool CanComplete
        {
            get { return default(bool); }
        }

        [JsonIgnore]
        public bool CanFlip
        {
            get { return default(bool); }
        }

        [JsonIgnore]
        public EventContentTreasureInfo TreasureInfo
        {
            get { return null; }
        }

        [JsonIgnore]
        public EventContentTreasureRoundInfo TreasureRoundInfo
        {
            get { return null; }
        }

        public EventContentTreasureHistoryDB() { }

        private EventContentTreasureInfo _treasureInfo;

        private EventContentTreasureRoundInfo _treasureRoundInfo;
    }
}
