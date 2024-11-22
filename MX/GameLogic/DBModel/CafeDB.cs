using System.Collections.Generic;
using FlatData;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class CafeDB
    {
        public long CafeDBId { get; set; }

        public long CafeId { get; set; }

        public long AccountId { get; set; }

        public int CafeRank { get; set; }

        public DateTime LastUpdate { get; set; }

        public DateTime? LastSummonDate { get; set; }

        public bool IsNew { get; set; }

        public Dictionary<long, CafeDB.CafeCharacterDB> CafeVisitCharacterDBs { get; set; }

        public List<FurnitureDB> FurnitureDBs { get; set; }

        public DateTime ProductionAppliedTime { get; set; }

        public CafeProductionDB ProductionDB { get; set; }

        [JsonIgnore]
        public Dictionary<CurrencyTypes, long> CurrencyDict_Obsolete { get; set; }

        [JsonIgnore]
        public Dictionary<CurrencyTypes, DateTime> UpdateTimeDict_Obsolete { get; set; }

        public CafeDB() { }

        public CafeDB(CafeDB other) { }

        public CafeDB Clone()
        {
            return null;
        }

        public class CafeCharacterDB : VisitingCharacterDB
        {
            public bool IsSummon { get; set; }

            public DateTime LastInteractTime { get; set; }

            public CafeDB.CafeCharacterDB Clone()
            {
                return null;
            }

            public CafeCharacterDB() { }
        }
    }
}
