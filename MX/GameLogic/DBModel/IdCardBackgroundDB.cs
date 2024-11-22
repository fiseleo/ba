using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FlatData;
using MX.GameLogic.Parcel;

namespace MX.GameLogic.DBModel
{
    public class IdCardBackgroundDB : ParcelBase
    {
        public override ParcelType Type
        {
            get { return ParcelType.IdCardBackground; }
        }

        [Key]
        public long ServerId { get; set; }

        public long UniqueId { get; set; }

        public override IEnumerable<ParcelInfo> ParcelInfos
        {
            get { return null; }
        }

        public IdCardBackgroundDB() { }
    }
}
