using FlatData;

namespace MX.GameLogic.DBModel
{
    public class RaidBossDB
    {
        public ContentType ContentType { get; set; }

        public int BossIndex { get; set; }

        public long BossCurrentHP { get; set; }

        public long BossGroggyPoint { get; set; }

        public static RaidBossDB Clone(RaidBossDB db)
        {
            return null;
        }

        public RaidBossDB Clone()
        {
            return null;
        }

        public RaidBossDB() { }
    }
}
