namespace MX.NetworkProtocol
{
    public class CheatWeaponCustomPreset
    {
        public CheatWeaponCustomPreset(int weaponStarGrade, int weaponLevel) { }

        public int StarGrade { get; set; }

        public int Level { get; set; }

        public CheatWeaponCustomPreset Clone()
        {
            return null;
        }
    }
}
