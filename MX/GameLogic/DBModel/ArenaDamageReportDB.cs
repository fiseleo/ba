using System.Collections.Generic;

namespace MX.GameLogic.DBModel
{
    public class ArenaDamageReportDB
    {
        public long ArenaBattleServerId { get; set; }

        public long WinnerAccountServerId { get; set; }

        public ArenaUserDB AttackerUserDB { get; set; }

        public ArenaUserDB DefenderUserDB { get; set; }

        public DateTime BattleEndTime { get; set; }

        public Dictionary<long, long> AttackerDamageReport { get; set; }

        public Dictionary<long, long> DefenderDamageReport { get; set; }

        public bool IsWinner(long accountId)
        {
            return default(bool);
        }

        public bool IsAttacker(long accountId)
        {
            return default(bool);
        }

        public ArenaUserDB MyArenaUserDB(long accountId)
        {
            return null;
        }

        public ArenaUserDB OpponentArenaUserDB(long accountId)
        {
            return null;
        }

        public Dictionary<long, long> MyDamageReport(long accountId)
        {
            return null;
        }

        public Dictionary<long, long> OpponentDamageReport(long accountId)
        {
            return null;
        }

        public ArenaDamageReportDB() { }
    }
}
