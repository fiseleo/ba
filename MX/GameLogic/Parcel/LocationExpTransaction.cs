using System.Collections.Generic;
using FlatData;
using Newtonsoft.Json;

namespace MX.GameLogic.Parcel
{
    public class LocationExpTransaction : ParcelBase
    {
        public override ParcelType Type
        {
            get { return ParcelType.None; }
        }

        [JsonIgnore]
        public override IEnumerable<ParcelInfo> ParcelInfos
        {
            get { return null; }
        }

        public long TargetLocationUniqueId { get; set; }

        public long Amount { get; }

        public LocationExpTransaction(long targetLocationUniqueId, long amount) { }
    }
}
