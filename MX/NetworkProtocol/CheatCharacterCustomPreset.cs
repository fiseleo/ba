namespace MX.NetworkProtocol
{
    public class CheatCharacterCustomPreset
    {
        public long UniqueId { get; set; }

        public int StarGrade { get; set; }

        public int Level { get; set; }

        public int ExSkillLevel { get; set; }

        public int PublicSkillLevel { get; set; }

        public int PassiveSkillLevel { get; set; }

        public int ExPassiveSkillLevel { get; set; }

        public CheatEquipmentCustomPreset[] Equipments { get; set; }

        public CheatWeaponCustomPreset Weapon { get; set; }

        public CheatCharacterCustomPreset Clone()
        {
            return null;
        }

        public CheatCharacterCustomPreset() { }
    }
}
