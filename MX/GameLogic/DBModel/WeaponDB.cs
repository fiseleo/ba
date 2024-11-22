using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using FlatData;
using MX.GameLogic.Parcel;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class WeaponDB : ParcelBase
    {
        public override ParcelType Type
        {
            get { return ParcelType.CharacterWeapon; }
        }

        [JsonIgnore]
        public override IEnumerable<ParcelInfo> ParcelInfos
        {
            get { return null; }
        }

        public long UniqueId { get; set; }

        [DefaultValue(1)]
        public int Level { get; set; } = 1;

        [DefaultValue(0)]
        public long Exp { get; set; }

        [DefaultValue(1)]
        public int StarGrade { get; set; } = 1;

        public long BoundCharacterServerId { get; set; }

        [DefaultValue(0)]
        public bool IsLocked { get; set; }

        public WeaponDB() { }

        public override string ToString()
        {
            return null;
        }

        public WeaponDB Clone()
        {
            return null;
        }

        public static bool Equivalent(WeaponDB first, WeaponDB second)
        {
            return default(bool);
        }
    }
}
