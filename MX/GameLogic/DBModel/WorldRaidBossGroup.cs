using FlatData;

namespace MX.GameLogic.DBModel
{
    public class WorldRaidBossGroup : ContentsValueChangeDB
    {
        public override ContentsChangeType ContentsChangeType
        {
            get { return ContentsChangeType.None; }
        }

        public long GroupId { get; set; }

        public DateTime BossSpawnTime { get; set; }

        public DateTime EliminateTime { get; set; }

        public WorldRaidBossGroup(long id, string bossSpawnTime, string eliminateTime) { }
    }
}
