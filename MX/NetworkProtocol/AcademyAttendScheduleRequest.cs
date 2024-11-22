namespace MX.NetworkProtocol
{
    public class AcademyAttendScheduleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Academy_AttendSchedule; }
        }

        public long ZoneId { get; set; }

        public AcademyAttendScheduleRequest() { }
    }
}
