using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FlatData;
using MX.GameLogic.Parcel;

namespace MX.GameLogic.DBModel
{
    public class StickerDB : ParcelBase, IEquatable<StickerDB>
    {
        public override ParcelType Type
        {
            get { return ParcelType.Sticker; }
        }

        [Key]
        public long StickerUniqueId { get; set; }

        public override IEnumerable<ParcelInfo> ParcelInfos
        {
            get { return null; }
        }

        public bool Equals(StickerDB other)
        {
            return StickerUniqueId == other.StickerUniqueId;
        }

        public StickerDB() { }
    }
}
