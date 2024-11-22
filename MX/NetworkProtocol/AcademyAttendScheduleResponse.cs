using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class AcademyAttendScheduleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Academy_AttendSchedule; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public AcademyDB AcademyDB { get; set; }

        public List<ParcelInfo> ExtraRewards { get; set; }

        public AcademyAttendScheduleResponse() { }
    }
}
