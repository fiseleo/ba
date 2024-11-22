using System.Collections.Generic;
using FlatData;
using Microsoft.EntityFrameworkCore;
using MX.GameLogic.Parcel;

namespace MX.GameLogic.DBModel
{
    [PrimaryKey(nameof(ReceiveDate), nameof(UniqueId))]
    public class EmblemDB : ParcelBase
    {
        public override ParcelType Type
        {
            get { return ParcelType.Emblem; }
        }

        public long UniqueId { get; set; }

        public DateTime ReceiveDate { get; set; }

        public override IEnumerable<ParcelInfo> ParcelInfos
        {
            get { return null; }
        }

        public EmblemDB() { }

        public EmblemDB(long uniqueId, DateTime receiveDate) { }
    }
}
