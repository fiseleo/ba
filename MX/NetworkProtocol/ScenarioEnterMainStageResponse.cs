using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ScenarioEnterMainStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_EnterMainStage; }
        }

        public StoryStrategyStageSaveDB SaveDataDB { get; set; }

        public ScenarioEnterMainStageResponse() { }
    }
}
