using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FlatData;
using MX.GameLogic.Parcel;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class CostumeDB : ParcelBase
    {
        public override ParcelType Type
        {
            get { return ParcelType.Costume; }
        }

        [JsonIgnore]
        public override IEnumerable<ParcelInfo> ParcelInfos
        {
            get { return null; }
        }

        public long UniqueId { get; set; }

        [Key]
        public long BoundCharacterServerId { get; set; }

        public CostumeDB() { }
    }
}
