using FlatData;

namespace MX.GameLogic.DBModel
{
    public class ClearDeckCharacterDB
    {
        public long UniqueId { get; set; }

        public int StarGrade { get; set; }

        public int Level { get; set; }

        public int SlotNumber { get; set; }

        public bool HasWeapon { get; set; }

        public SquadType SquadType { get; set; }

        public int WeaponStarGrade { get; set; }

        public int CombatStyleIndex { get; set; }

        public ClearDeckCharacterDB() { }
    }
}
