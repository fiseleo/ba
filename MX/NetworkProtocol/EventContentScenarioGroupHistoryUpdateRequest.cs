namespace MX.NetworkProtocol
{
    public class EventContentScenarioGroupHistoryUpdateRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_ScenarioGroupHistoryUpdate; }
        }

        public long ScenarioGroupUniqueId { get; set; }

        public long ScenarioType { get; set; }

        public long EventContentId { get; set; }

        public EventContentScenarioGroupHistoryUpdateRequest() { }
    }
}
