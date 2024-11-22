using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class ScenarioRestartMainStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_RestartMainStage; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public StoryStrategyStageSaveDB SaveDataDB { get; set; }

        public ScenarioRestartMainStageResponse() { }
    }
}
