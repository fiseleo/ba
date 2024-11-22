using System.Collections.Generic;

namespace MX.GameLogic.DBModel
{
    public class RaidDetailDB
    {
        public long RaidUniqueId { get; set; }

        public DateTime EndDate { get; set; }

        public List<RaidPlayerInfoDB> DamageTable { get; set; } = [];

        public bool ShouldSerializeDamageTable()
        {
            return DamageTable.Count > 0;
        }

        public RaidDetailDB(long uniqueId, DateTime endDate) { }
    }
}
