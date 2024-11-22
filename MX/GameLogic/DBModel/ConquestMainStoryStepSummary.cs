namespace MX.GameLogic.DBModel
{
    public class ConquestMainStoryStepSummary
    {
        public long ConqueredTileCount { get; set; }

        public long AllTileCount { get; set; }

        public bool IsStepOpen { get; set; }

        public ConquestMainStoryStepSummary() { }
    }
}
