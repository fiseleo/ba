using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ScenarioWithdrawEchelonResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_WithdrawEchelon; }
        }

        public StoryStrategyStageSaveDB SaveDataDB { get; set; }

        public List<EchelonDB> WithdrawEchelonDBs { get; set; }

        public ScenarioWithdrawEchelonResponse() { }
    }
}
