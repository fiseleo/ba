namespace MX.NetworkProtocol
{
    public class ScenarioEnterRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_Enter; }
        }

        public long ScenarioId { get; set; }

        public ScenarioEnterRequest() { }
    }
}
