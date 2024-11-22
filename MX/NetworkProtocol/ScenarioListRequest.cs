namespace MX.NetworkProtocol
{
    public class ScenarioListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_List; }
        }

        public ScenarioListRequest() { }
    }
}
