namespace MX.GameLogic.DBModel
{
    public class ConquestStepSummary
    {
        public long ConqueredTileCount { get; set; }

        public long AllTileCount { get; set; }

        public long ErosionRemainingCount { get; set; }

        public bool HasPhaseComplete { get; set; }

        public bool IsErosionPhaseStart { get; set; }

        public bool IsStepOpen { get; set; }

        public ConquestStepSummary() { }
    }
}
