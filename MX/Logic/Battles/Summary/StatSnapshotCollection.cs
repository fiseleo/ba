using System.Collections.ObjectModel;
using FlatData;

namespace MX.Logic.Battles.Summary
{
    public class StatSnapshotCollection : KeyedCollection<StatType, StatSnapshot>
    {
        protected override StatType GetKeyForItem(StatSnapshot item)
        {
            return item.Stat;
        }
    }
}
