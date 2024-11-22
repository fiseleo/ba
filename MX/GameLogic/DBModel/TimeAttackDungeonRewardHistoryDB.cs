using System.Collections.Generic;

namespace MX.GameLogic.DBModel
{
    public class TimeAttackDungeonRewardHistoryDB
    {
        public static IEnumerable<TimeAttackDungeonRewardHistoryDB> GenerateFromRoomDBs(
            IEnumerable<TimeAttackDungeonRoomDB> roomDBs,
            DateTime currentTime
        )
        {
            return null;
        }

        public DateTime Date { get; set; }

        public TimeAttackDungeonRoomDB RoomDB { get; set; }

        public bool IsSweep { get; set; }

        public TimeAttackDungeonRewardHistoryDB() { }
    }
}
