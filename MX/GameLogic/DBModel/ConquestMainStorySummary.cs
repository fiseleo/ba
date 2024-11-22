using System.Collections.Generic;
using FlatData;

namespace MX.GameLogic.DBModel
{
    public class ConquestMainStorySummary
    {
        public long EventContentId { get; set; }

        public StageDifficulty Difficulty { get; set; }

        public Dictionary<int, ConquestMainStoryStepSummary> ConquestStepSummaryDict { get; set; }

        public ConquestMainStorySummary() { }
    }
}
