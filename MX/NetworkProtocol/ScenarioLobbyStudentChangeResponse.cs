namespace MX.NetworkProtocol
{
    public class ScenarioLobbyStudentChangeResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_LobbyStudentChange; }
        }

        public ScenarioLobbyStudentChangeResponse() { }
    }
}
