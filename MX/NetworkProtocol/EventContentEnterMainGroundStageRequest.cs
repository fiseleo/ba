namespace MX.NetworkProtocol
{
    public class EventContentEnterMainGroundStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_EnterMainGroundStage; }
        }

        public long EventContentId { get; set; }

        public long StageUniqueId { get; set; }

        public long LastEnterStageEchelonNumber { get; set; }

        public EventContentEnterMainGroundStageRequest() { }
    }
}
