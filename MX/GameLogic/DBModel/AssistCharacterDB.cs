using System.Collections.Generic;
using FlatData;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class AssistCharacterDB : CharacterDB
    {
        public EchelonType EchelonType { get; set; }

        public int SlotNumber { get; set; }

        public long AccountId { get; set; }

        public AssistRelation AssistRelation { get; set; }

        public long AssistCharacterServerId { get; set; }

        public string NickName { get; set; }

        public List<EquipmentDB> EquipmentDBs { get; set; }

        public WeaponDB WeaponDB { get; set; }

        public GearDB GearDB { get; set; }

        public long CostumeId { get; set; }

        public CostumeDB CostumeDB
        {
            get { return null; }
        }

        public bool IsMulligan { get; set; }

        public bool IsTSAInteraction { get; set; }

        public int CombatStyleIndex { get; set; }

        [JsonIgnore]
        public bool HasWeapon
        {
            get { return default(bool); }
        }

        public AssistCharacterDB CloneAssist()
        {
            return null;
        }

        [JsonIgnore]
        public bool HasGear
        {
            get { return default(bool); }
        }

        public AssistCharacterDB() { }

        private CostumeDB _costumeDB;
    }
}
