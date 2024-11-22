using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class ScenarioConfirmMainStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_ConfirmMainStage; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public StoryStrategyStageSaveDB SaveDataDB { get; set; }

        public List<long> ScenarioIds { get; set; }

        public ScenarioConfirmMainStageResponse() { }
    }
}
