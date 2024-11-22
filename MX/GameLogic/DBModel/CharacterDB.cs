using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FlatData;
using MX.GameLogic.Parcel;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class CharacterDB : ParcelBase
    {
        public CharacterDB() { }

        public override ParcelType Type
        {
            get { return ParcelType.Character; }
        }

        [JsonIgnore]
        public override IEnumerable<ParcelInfo> ParcelInfos
        {
            get { return null; }
        }

        [Key]
        public long ServerId { get; set; }

        public long UniqueId { get; set; }

        public int StarGrade { get; set; } = 1;

        public int Level { get; set; } = 1;

        public long Exp { get; set; } = 0;

        public int FavorRank { get; set; } = 1;

        public long FavorExp { get; set; } = 0;

        public int PublicSkillLevel { get; set; } = 1;

        public int ExSkillLevel { get; set; } = 1;

        public int PassiveSkillLevel { get; set; } = 1;

        public int ExtraPassiveSkillLevel { get; set; } = 1;

        public int LeaderSkillLevel { get; set; } = 1;

        public bool IsNew { get; set; } = true;

        public bool IsLocked { get; set; } = true;

        public bool IsFavorite { get; set; }

        public List<long> EquipmentServerIds { get; set; } = [0, 0, 0];

        public bool ShouldSerializeEquipmentServerIds()
        {
            return true;
        }

        public Dictionary<int, int> PotentialStats { get; set; } =
            new Dictionary<int, int>
            {
                { 1, 0 },
                { 2, 0 },
                { 3, 0 }
            };

        public bool ShouldSerializePotentialStats()
        {
            return true;
        }

        // [JsonIgnore]
        // public Dictionary<int, long> EquipmentSlotAndDBIds
        // {
        //     get { return []; }
        // }

        public CharacterDB Clone()
        {
            return null;
        }

        public override string ToString()
        {
            return null;
        }

        public static bool Equivalent(CharacterDB first, CharacterDB second)
        {
            return default(bool);
        }
    }
}
