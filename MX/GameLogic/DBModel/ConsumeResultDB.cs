using System.Collections.Generic;

namespace MX.GameLogic.DBModel
{
    public class ConsumeResultDB
    {
        public List<long> RemovedItemServerIds { get; set; }

        public List<long> RemovedEquipmentServerIds { get; set; }

        public List<long> RemovedFurnitureServerIds { get; set; }

        public bool ShouldSerializeRemovedItemServerIds()
        {
            return default(bool);
        }

        public bool ShouldSerializeRemovedEquipmentServerIds()
        {
            return default(bool);
        }

        public bool ShouldSerializeRemovedFurnitureServerIds()
        {
            return default(bool);
        }

        public Dictionary<long, long> UsedItemServerIdAndRemainingCounts { get; set; }

        public Dictionary<long, long> UsedEquipmentServerIdAndRemainingCounts { get; set; }

        public Dictionary<long, long> UsedFurnitureServerIdAndRemainingCounts { get; set; }

        public bool ShouldSerializeUsedItemServerIdAndRemainingCounts()
        {
            return default(bool);
        }

        public bool ShouldSerializeUsedEquipmentServerIdAndRemainingCounts()
        {
            return default(bool);
        }

        public bool ShouldSerializeUsedFurnitureServerIdAndRemainingCounts()
        {
            return default(bool);
        }

        public ConsumeResultDB() { }

        public ConsumeResultDB WithItems(
            Dictionary<long, long> usedServerIdAndRemainingCounts,
            List<long> removedServerIds
        )
        {
            return null;
        }

        public ConsumeResultDB WithEquipments(
            Dictionary<long, long> usedServerIdAndRemainingCounts,
            List<long> removedServerIds
        )
        {
            return null;
        }

        public ConsumeResultDB WithFurnitures(
            Dictionary<long, long> usedServerIdAndRemainingCounts,
            List<long> removedServerIds
        )
        {
            return null;
        }
    }
}
