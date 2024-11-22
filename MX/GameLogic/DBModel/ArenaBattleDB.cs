using MX.Logic.Battles.Summary;

namespace MX.GameLogic.DBModel
{
    public class ArenaBattleDB
    {
        public long ArenaBattleServerId { get; set; }

        public long Season { get; set; }

        public long Group { get; set; }

        public DateTime BattleStartTime { get; set; }

        public DateTime BattleEndTime { get; set; }

        public long Seed { get; set; }

        public ArenaUserDB AttackingUserDB { get; set; }

        public ArenaUserDB DefendingUserDB { get; set; }

        public BattleSummary BattleSummary { get; set; }

        public ArenaBattleDB() { }
    }
}
