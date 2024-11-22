namespace MX.NetworkProtocol
{
    public class CheatEquipmentCustomPreset
    {
        public int Tier { get; set; }

        public int Level { get; set; }

        public CheatEquipmentCustomPreset(int tier, int level) { }

        public CheatEquipmentCustomPreset Clone()
        {
            return null;
        }
    }
}
