using System.Runtime.InteropServices;

namespace MX.GameLogic.DBModel
{
    public class TimeAttackDungeonCharacterDB
    {
        public long ServerId { get; set; }

        public long UniqueId { get; set; }

        public long CostumeId { get; set; }

        public int StarGrade { get; set; }

        public int Level { get; set; }

        public bool HasWeapon { get; set; }

        public WeaponDB WeaponDB { get; set; }

        public bool IsAssist { get; set; }

        public TimeAttackDungeonCharacterDB() { }

        public TimeAttackDungeonCharacterDB(
            CharacterDB characterDB,
            [Optional] WeaponDB weaponDB,
            long costumeId = 0L
        ) { }

        public TimeAttackDungeonCharacterDB(
            AssistCharacterDB characterDB,
            [Optional] WeaponDB weaponDB
        ) { }
    }
}
