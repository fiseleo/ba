using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using FlatData;
using Newtonsoft.Json;

namespace MX.GameLogic.Parcel
{
    public abstract class ParcelBase
    {
        [NotMapped]
        public abstract ParcelType Type { get; }

        [JsonIgnore]
        [NotMapped]
        public abstract IEnumerable<ParcelInfo> ParcelInfos { get; }

        public override string ToString()
        {
            return null;
        }

        protected ParcelBase() { }
    }
}
