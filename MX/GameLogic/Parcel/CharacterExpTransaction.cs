using System.Collections.Generic;
using FlatData;
using Newtonsoft.Json;

namespace MX.GameLogic.Parcel
{
    public class CharacterExpTransaction : ParcelBase
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

        public long TargetCharacterUniqueId { get; set; }

        public long Amount { get; }

        public CharacterExpTransaction(long targetCharacterUniqueId, long amount) { }
    }
}
