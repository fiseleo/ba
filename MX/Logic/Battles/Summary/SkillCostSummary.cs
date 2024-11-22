namespace MX.Logic.Battles.Summary
{
    public class SkillCostSummary
    {
        public float InitialCost { get; set; }

        public CostRegenSnapshotCollection CostPerFrameSnapshots { get; set; }

        public List<SkillCostAddSnapshot> CostAddSnapshots { get; set; }
    }
}
