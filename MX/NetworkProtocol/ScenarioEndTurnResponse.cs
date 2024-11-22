using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ScenarioEndTurnResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_EndTurn; }
        }

        public StoryStrategyStageSaveDB SaveDataDB { get; set; }

        public AccountCurrencyDB AccountCurrencyDB { get; set; }

        public List<long> ScenarioIds { get; set; }

        public ScenarioEndTurnResponse() { }
    }
}
