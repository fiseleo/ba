namespace MX.NetworkProtocol
{
    public class EventContentReceiveStageTotalRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_ReceiveStageTotalReward; }
        }

        public long EventContentId { get; set; }

        public EventContentReceiveStageTotalRewardRequest() { }
    }
}
