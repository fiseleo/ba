namespace MX.NetworkProtocol
{
    public class ScenarioSelectRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_Select; }
        }

        public long ScriptGroupId { get; set; }

        public long ScriptSelectGroup { get; set; }

        public ScenarioSelectRequest() { }
    }
}
