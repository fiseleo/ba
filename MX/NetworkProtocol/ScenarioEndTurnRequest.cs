namespace MX.NetworkProtocol
{
    public class ScenarioEndTurnRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_EndTurn; }
        }

        public long StageUniqueId { get; set; }

        public ScenarioEndTurnRequest() { }
    }
}
