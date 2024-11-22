using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ScenarioDeployEchelonResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_DeployEchelon; }
        }

        public StoryStrategyStageSaveDB SaveDataDB { get; set; }

        public ScenarioDeployEchelonResponse() { }
    }
}
