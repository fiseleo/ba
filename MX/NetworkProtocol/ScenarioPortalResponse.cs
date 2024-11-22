using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ScenarioPortalResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_Portal; }
        }

        public StoryStrategyStageSaveDB StoryStrategyStageSaveDB { get; set; }

        public List<long> ScenarioIds { get; set; }

        public ScenarioPortalResponse() { }
    }
}
