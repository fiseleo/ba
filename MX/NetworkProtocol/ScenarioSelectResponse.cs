namespace MX.NetworkProtocol
{
    public class ScenarioSelectResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_Select; }
        }

        public ScenarioSelectResponse() { }
    }
}
