using System.Collections.Generic;
using FlatData;

namespace MX.GameLogic.DBModel
{
    public interface IConsumableItemBaseExcel
    {
        ParcelType Type { get; }

        long UniqueId { get; }

        long ShiftingCraftQuality { get; }

        long StackableMax { get; }

        Rarity Rarity { get; }

        IReadOnlyList<Tag> Tags { get; }

        IReadOnlyDictionary<CraftNodeTier, long> CraftQualityDict { get; }

        bool TryGetCraftQuality(CraftNodeTier tier, out long quality);
    }
}
