using System.Collections.Generic;

namespace MX.GameLogic.DBModel
{
    public class SelectGachaSnapshotDB
    {
        public long ShopUniqueId { get; set; }

        public long LastIndex { get; set; }

        public List<long> LastResults { get; set; }

        public long? SavedIndex { get; set; }

        public List<long> SavedResults { get; set; }

        public long? PickedIndex { get; set; }

        public SelectGachaSnapshotDB() { }
    }
}
