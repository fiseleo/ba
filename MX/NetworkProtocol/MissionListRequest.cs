namespace MX.NetworkProtocol
{
    public class MissionListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Mission_List; }
        }

        public long? EventContentId { get; set; }

        public MissionListRequest() { }
    }
}
