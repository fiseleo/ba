using FlatData;

namespace MX.NetworkProtocol
{
    public class MissionMultipleRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Mission_MultipleReward; }
        }

        public MissionCategory MissionCategory { get; set; }

        public long? GuideMissionSeasonId { get; set; }

        public long? EventContentId { get; set; }

        public MissionMultipleRewardRequest() { }
    }
}
