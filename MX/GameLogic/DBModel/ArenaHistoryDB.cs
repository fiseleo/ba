using MX.Logic.Battles.Summary;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class ArenaHistoryDB
    {
        public ArenaBattleDB ArenaBattleDB { get; set; }

        [JsonIgnore]
        public DateTime BattleEndTime
        {
            get { return default(DateTime); }
        }

        [JsonIgnore]
        public BattleSummary BattleSummary
        {
            get { return null; }
        }

        [JsonIgnore]
        public ArenaUserDB AttackingUserDB
        {
            get { return null; }
        }

        [JsonIgnore]
        public ArenaUserDB DefendingUserDB
        {
            get { return null; }
        }

        [JsonIgnore]
        public long WinnerAccountServerId
        {
            get { return 0L; }
        }

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

        public GroupSummary MyGroupSummary(long accountId)
        {
            return null;
        }

        public GroupSummary OpponentGroupSummary(long accountId)
        {
            return null;
        }

        public ArenaHistoryDB() { }
    }
}
