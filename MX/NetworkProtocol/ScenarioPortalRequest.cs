namespace MX.NetworkProtocol
{
    public class ScenarioPortalRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_Portal; }
        }

        public long StageUniqueId { get; set; }

        public long EchelonEntityId { get; set; }

        public ScenarioPortalRequest() { }
    }
}
