using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FlatData;
using MX.GameLogic.Parcel;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class GearDB : ParcelBase
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

        [Key]
        public long ServerId { get; set; }

        public long UniqueId { get; set; }

        public int Level { get; set; }

        public long Exp { get; set; }

        public int Tier { get; set; }

        public long SlotIndex { get; set; }

        public long BoundCharacterServerId { get; set; }

        public GearDB Clone()
        {
            return null;
        }

        public static GearDB Create(long uniqueId, long slotIndex, long characterServerId)
        {
            return null;
        }

        public EquipmentDB ToEquipmentDB
        {
            get
            {
                return new()
                {
                    IsNew = true,
                    ServerId = ServerId,
                    BoundCharacterServerId = BoundCharacterServerId,
                    Tier = Tier,
                    Level = Level,
                    StackCount = 1,
                    Exp = Exp
                };
            }
        }

        public GearDB() { }
    }
}
