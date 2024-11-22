using System.Collections.Generic;
using MX.GameLogic.Parcel;

namespace MX.GameLogic.DBModel
{
    public class CafeProductionDB
    {
        public long CafeDBId { get; set; }

        public long ComfortValue { get; set; }

        public DateTime AppliedDate { get; set; }

        public List<CafeProductionDB.CafeProductionParcelInfo> ProductionParcelInfos { get; set; }

        public CafeProductionDB() { }

        public void ResetProductionValues() { }

        public CafeProductionDB Clone()
        {
            return null;
        }

        public class CafeProductionParcelInfo
        {
            public ParcelKeyPair Key { get; set; }

            public long Amount { get; set; }

            public CafeProductionDB.CafeProductionParcelInfo Clone()
            {
                return null;
            }

            public CafeProductionParcelInfo() { }
        }
    }
}
