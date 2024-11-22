using System.Collections.Generic;
using FlatData;
using Newtonsoft.Json;

namespace MX.GameLogic.Parcel
{
    public class AccountExpTransaction : ParcelBase
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

        public long Amount { get; }

        public AccountExpTransaction(long amount) { }

        public override string ToString()
        {
            return null;
        }
    }
}
