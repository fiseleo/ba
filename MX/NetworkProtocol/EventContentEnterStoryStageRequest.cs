namespace MX.NetworkProtocol
{
    public class EventContentEnterStoryStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_EnterStoryStage; }
        }

        public long StageUniqueId { get; set; }

        public long EventContentId { get; set; }

        public EventContentEnterStoryStageRequest() { }
    }
}
