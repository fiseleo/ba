namespace MX.NetworkProtocol
{
    public class ScenarioRetreatRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_Retreat; }
        }

        public long StageUniqueId { get; set; }

        public ScenarioRetreatRequest() { }
    }
}
