namespace MX.NetworkProtocol
{
    public class EventContentStoryStageResultRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_StoryStageResult; }
        }

        public long EventContentId { get; set; }

        public long StageUniqueId { get; set; }

        public EventContentStoryStageResultRequest() { }
    }
}
