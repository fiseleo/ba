using System.Collections.Generic;
using FlatData;

namespace MX.GameLogic.DBModel
{
    public class ConquestSummary
    {
        public long EventContentId { get; set; }

        public StageDifficulty Difficulty { get; set; }

        public Dictionary<int, ConquestStepSummary> ConquestStepSummaryDict { get; set; }

        public ConquestSummary() { }

        public ConquestSummary(
            long eventContentId,
            StageDifficulty difficulty,
            Dictionary<int, ConquestStepSummary> conquestStepSummaryDict
        ) { }
    }
}
