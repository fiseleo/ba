using System.Collections.Generic;

namespace MX.NetworkProtocol
{
    public class AttendanceRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Attendance_Reward; }
        }

        public Dictionary<long, long> DayByBookUniqueId { get; set; }

        public long AttendanceBookUniqueId { get; set; }

        public long Day { get; set; }

        public AttendanceRewardRequest() { }
    }
}
