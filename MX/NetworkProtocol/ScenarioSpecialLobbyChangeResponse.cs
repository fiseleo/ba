namespace MX.NetworkProtocol
{
    public class ScenarioSpecialLobbyChangeResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_SpecialLobbyChange; }
        }

        public ScenarioSpecialLobbyChangeResponse() { }
    }
}
