namespace MX.NetworkProtocol
{
    public class EventContentEnterSubStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_EnterSubStage; }
        }

        public long EventContentId { get; set; }

        public long StageUniqueId { get; set; }

        public long LastEnterStageEchelonNumber { get; set; }

        public EventContentEnterSubStageRequest() { }
    }
}
