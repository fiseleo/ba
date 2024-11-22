using System.Collections.Generic;
using MX.Campaign;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ScenarioTacticResultResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_TacticResult; }
        }

        public Strategy StrategyObject { get; set; }

        public StoryStrategyStageSaveDB SaveDataDB { get; set; }

        public bool IsPlayerWin { get; set; }

        public List<long> ScenarioIds { get; set; }

        public ScenarioTacticResultResponse() { }
    }
}
