namespace MX.GameLogic.DBModel
{
    public class WorldRaidLocalBossDB
    {
        public long SeasonId { get; set; }

        public long GroupId { get; set; }

        public long UniqueId { get; set; }

        public bool IsScenario { get; set; }

        public bool IsCleardEver { get; set; }

        public long TacticMscSum { get; set; }

        public RaidBattleDB RaidBattleDB { get; set; }

        public bool IsContinue
        {
            get { return default(bool); }
        }

        public void AccumulateClearTime(long milliseconds) { }

        public WorldRaidLocalBossDB Clone()
        {
            return null;
        }

        public WorldRaidLocalBossDB() { }
    }
}
