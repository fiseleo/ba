using System.Collections.Generic;

namespace MX.NetworkProtocol
{
    public class ScenarioLobbyStudentChangeRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_LobbyStudentChange; }
        }

        public List<long> LobbyStudents { get; set; }

        public List<long> LobbyStudentsBefore { get; set; }

        public ScenarioLobbyStudentChangeRequest() { }
    }
}
