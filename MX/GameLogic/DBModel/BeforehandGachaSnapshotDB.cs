using System.Collections.Generic;

namespace MX.GameLogic.DBModel
{
    public class BeforehandGachaSnapshotDB
    {
        public long ShopUniqueId { get; set; }

        public long GoodsId { get; set; }

        public long LastIndex { get; set; }

        public List<long> LastResults { get; set; }

        public long? SavedIndex { get; set; }

        public List<long> SavedResults { get; set; }

        public long? PickedIndex { get; set; }

        public BeforehandGachaSnapshotDB() { }
    }
}
