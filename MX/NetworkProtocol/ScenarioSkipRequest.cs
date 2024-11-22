namespace MX.NetworkProtocol
{
    public class ScenarioSkipRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_Skip; }
        }

        public long ScriptGroupId { get; set; }

        public int SkipPointScriptCount { get; set; }

        public ScenarioSkipRequest() { }
    }
}
