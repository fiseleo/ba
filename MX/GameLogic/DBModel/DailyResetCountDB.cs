using System.Collections.Generic;
using FlatData;

namespace MX.GameLogic.DBModel
{
    public class DailyResetCountDB
    {
        public long AccountServerId { get; set; }

        public Dictionary<ResetContentType, long> ResetCount { get; set; }

        public DailyResetCountDB() { }

        public DailyResetCountDB(long accountId) { }
    }
}
