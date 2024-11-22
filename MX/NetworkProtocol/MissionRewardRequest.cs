namespace MX.NetworkProtocol
{
    public class MissionRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Mission_Reward; }
        }

        public long MissionUniqueId { get; set; }

        public long ProgressServerId { get; set; }

        public long? EventContentId { get; set; }

        public MissionRewardRequest() { }
    }
}
