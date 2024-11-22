using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using FlatData;
using MX.GameLogic.Parcel;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class EquipmentDB : ConsumableItemBaseDB
    {
        public override ParcelType Type
        {
            get { return ParcelType.Equipment; }
        }

        [JsonIgnore]
        public override IEnumerable<ParcelInfo> ParcelInfos
        {
            get { return null; }
        }

        [DefaultValue(1)]
        public int Level { get; set; } = 1;

        [DefaultValue(0)]
        public long Exp { get; set; }

        [DefaultValue(1)]
        public int Tier { get; set; } = 1;

        public long BoundCharacterServerId { get; set; }

        [DefaultValue(1)]
        public bool IsNew { get; set; } = true;

        [DefaultValue(0)]
        public bool IsLocked { get; set; }

        [JsonIgnore]
        public override bool CanConsume
        {
            get { return false; }
        }

        public EquipmentDB() { }

        public override string ToString()
        {
            return null;
        }

        public EquipmentDB Clone()
        {
            return null;
        }

        public static bool Equivalent(EquipmentDB first, EquipmentDB second)
        {
            return default(bool);
        }
    }
}
