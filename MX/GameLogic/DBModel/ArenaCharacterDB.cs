using System.Collections.Generic;

namespace MX.GameLogic.DBModel
{
    public class ArenaCharacterDB
    {
        public long ServerId { get; set; }

        public long UniqueId { get; set; }

        public int StarGrade { get; set; }

        public int Level { get; set; }

        public int PublicSkillLevel { get; set; }

        public int ExSkillLevel { get; set; }

        public int PassiveSkillLevel { get; set; }

        public int ExtraPassiveSkillLevel { get; set; }

        public int LeaderSkillLevel { get; set; }

        public List<EquipmentDB> EquipmentDBs { get; set; }

        public Dictionary<long, long> FavorRankInfo { get; set; }

        public Dictionary<int, int> PotentialStats { get; set; }

        public int CombatStyleIndex { get; set; }

        public WeaponDB WeaponDB { get; set; }

        public GearDB GearDB { get; set; }

        public CostumeDB CostumeDB { get; set; }

        public ArenaCharacterDB() { }

        public ArenaCharacterDB(
            CharacterDB characterDB,
            IEnumerable<CharacterDB> characterDBs,
            IEnumerable<EquipmentDB> equipmentDBs,
            WeaponDB weaponDB,
            GearDB gearDB,
            CostumeDB costumeDB,
            int combatStyleIndex
        ) { }
    }
}
