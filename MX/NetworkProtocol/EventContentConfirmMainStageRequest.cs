namespace MX.NetworkProtocol
{
    public class EventContentConfirmMainStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_ConfirmMainStage; }
        }

        public long EventContentId { get; set; }

        public long StageUniqueId { get; set; }

        public EventContentConfirmMainStageRequest() { }
    }
}
