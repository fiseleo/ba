namespace MX.GameLogic.DBModel
{
    public class RaidCharacterDB
    {
        public long ServerId { get; set; }

        public long UniqueId { get; set; }

        public int StarGrade { get; set; }

        public int Level { get; set; }

        public int SlotIndex { get; set; }

        public long AccountId { get; set; }

        public bool IsAssist { get; set; }

        public bool HasWeapon { get; set; }

        public int WeaponStarGrade { get; set; }

        public long CostumeId { get; set; }

        public int CombatStyleIndex { get; set; }

        public static RaidCharacterDB Clone(RaidCharacterDB raidCharacterDB)
        {
            return null;
        }

        public RaidCharacterDB Clone()
        {
            return null;
        }

        public RaidCharacterDB() { }
    }
}
