namespace MX.NetworkProtocol
{
    public class ScenarioGroupHistoryUpdateRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_GroupHistoryUpdate; }
        }

        public long ScenarioGroupUniqueId { get; set; }

        public long ScenarioType { get; set; }

        public ScenarioGroupHistoryUpdateRequest() { }
    }
}
