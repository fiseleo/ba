using System.Collections.Generic;
using MX.Data;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class AttendanceRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Attendance_Reward; }
        }

        public List<AttendanceBookReward> AttendanceBookRewards { get; set; }

        public List<AttendanceHistoryDB> AttendanceHistoryDBs { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public AttendanceRewardResponse() { }
    }
}
