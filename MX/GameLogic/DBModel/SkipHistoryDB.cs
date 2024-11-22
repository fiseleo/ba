using System.Collections.Generic;

namespace MX.GameLogic.DBModel
{
    public class SkipHistoryDB
    {
        public long AccountServerId { get; set; }

        public int Prologue { get; set; }

        public Dictionary<int, int> Tutorial { get; set; }

        public SkipHistoryDB() { }
    }
}
