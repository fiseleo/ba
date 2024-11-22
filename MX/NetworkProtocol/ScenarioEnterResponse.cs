namespace MX.NetworkProtocol
{
    public class ScenarioEnterResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_Enter; }
        }

        public ScenarioEnterResponse() { }
    }
}
