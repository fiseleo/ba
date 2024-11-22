namespace MX.NetworkProtocol
{
    public class MomoTalkFavorScheduleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.MomoTalk_FavorSchedule; }
        }

        public long ScheduleId { get; set; }

        public MomoTalkFavorScheduleRequest() { }
    }
}
