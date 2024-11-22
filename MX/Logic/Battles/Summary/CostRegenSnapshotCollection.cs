using System.Collections.ObjectModel;

namespace MX.Logic.Battles.Summary
{
    public class CostRegenSnapshotCollection : KeyedCollection<long, SkillCostRegenSnapshot>
    {
        protected override long GetKeyForItem(SkillCostRegenSnapshot item)
        {
            return item.Frame;
        }
    }
}
