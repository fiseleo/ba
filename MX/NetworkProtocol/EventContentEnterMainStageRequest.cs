namespace MX.NetworkProtocol
{
    public class EventContentEnterMainStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_EnterMainStage; }
        }

        public long EventContentId { get; set; }

        public long StageUniqueId { get; set; }

        public EventContentEnterMainStageRequest() { }
    }
}
