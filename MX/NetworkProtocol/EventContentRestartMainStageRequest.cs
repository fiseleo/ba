namespace MX.NetworkProtocol
{
    public class EventContentRestartMainStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_RestartMainStage; }
        }

        public long EventContentId { get; set; }

        public long StageUniqueId { get; set; }

        public EventContentRestartMainStageRequest() { }
    }
}
