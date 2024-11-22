namespace MX.NetworkProtocol
{
    public class ScenarioSpecialLobbyChangeRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_SpecialLobbyChange; }
        }

        public long MemoryLobbyId { get; set; }

        public long MemoryLobbyIdBefore { get; set; }

        public ScenarioSpecialLobbyChangeRequest() { }
    }
}
