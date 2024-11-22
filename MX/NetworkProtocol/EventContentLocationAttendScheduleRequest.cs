namespace MX.NetworkProtocol
{
    public class EventContentLocationAttendScheduleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_LocationAttendSchedule; }
        }

        public long EventContentId { get; set; }

        public long ZoneId { get; set; }

        public long Count { get; set; }

        public EventContentLocationAttendScheduleRequest() { }
    }
}
