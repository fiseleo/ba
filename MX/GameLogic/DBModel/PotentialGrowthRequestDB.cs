using FlatData;

namespace MX.GameLogic.DBModel
{
    public class PotentialGrowthRequestDB
    {
        public PotentialStatBonusRateType Type { get; set; }

        public int Level { get; set; }

        public bool IsInvalid(int currentLevel)
        {
            return default(bool);
        }

        public PotentialGrowthRequestDB() { }
    }
}
