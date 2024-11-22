using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ScenarioListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_List; }
        }

        public List<ScenarioHistoryDB> ScenarioHistoryDBs { get; set; }

        public List<ScenarioGroupHistoryDB> ScenarioGroupHistoryDBs { get; set; }

        public ScenarioListResponse() { }
    }
}
