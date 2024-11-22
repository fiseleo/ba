using System.Collections.Generic;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class AttendanceHistoryDB
    {
        public AttendanceHistoryDB() { }

        public long ServerId { get; set; }

        public long AccountServerId { get; set; }

        public long AttendanceBookUniqueId { get; set; }

        public Dictionary<long, DateTime> AttendedDay { get; set; }

        public bool Expired { get; set; }

        [JsonIgnore]
        public long LastAttendedDay
        {
            get { return 0L; }
        }

        [JsonIgnore]
        public DateTime LastAttendedDate
        {
            get { return default(DateTime); }
        }

        [JsonIgnore]
        public Dictionary<long, DateTime?> AttendedDayNullable
        {
            get { return null; }
        }
    }
}
