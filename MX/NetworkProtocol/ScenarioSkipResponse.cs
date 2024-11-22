namespace MX.NetworkProtocol
{
    public class ScenarioSkipResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_Skip; }
        }

        public ScenarioSkipResponse() { }
    }
}
