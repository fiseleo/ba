using System.Collections.Generic;
using MX.Data;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class TimeAttackDungeonRoomDB
    {
        public long AccountId { get; set; }

        public long SeasonId { get; set; }

        public long RoomId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime RewardDate { get; set; }

        public bool IsPractice { get; set; }

        public List<DateTime> SweepHistoryDates { get; set; }

        public List<TimeAttackDungeonBattleHistoryDB> BattleHistoryDBs { get; set; }

        [JsonIgnore]
        public int PlayCount
        {
            get { return 0; }
        }

        [JsonIgnore]
        public long TotalPointSum
        {
            get { return 0L; }
        }

        [JsonIgnore]
        public bool IsRewardReceived
        {
            get { return default(bool); }
        }

        [JsonIgnore]
        public bool IsOpened
        {
            get { return default(bool); }
        }

        [JsonIgnore]
        public bool CanUseAssist
        {
            get { return default(bool); }
        }

        public bool IsTimeOut(DateTime currentTime)
        {
            return default(bool);
        }

        // public bool IsTimeOut(DateTime currentTime, TimeAttackDungeonSeasonInfo seasonInfo)
        // {
        //     return default(bool);
        // }

        [JsonIgnore]
        public bool IsPlayCountOver
        {
            get { return default(bool); }
        }

        public IEnumerable<long> GetUsedCharacterDBIds()
        {
            return null;
        }

        public override string ToString()
        {
            return null;
        }

        public static TimeAttackDungeonRoomDB FindTodayBestScoreRoomDB(
            DateTime serverTime,
            IEnumerable<TimeAttackDungeonRoomDB> roomDBs
        )
        {
            return null;
        }

        public static TimeAttackDungeonRoomDB FindTodayBestScoreRoomDBForSweep(
            DateTime serverTime,
            IEnumerable<TimeAttackDungeonRoomDB> roomDBs
        )
        {
            return null;
        }

        public TimeAttackDungeonRoomDB() { }
    }
}
