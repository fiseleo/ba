using System.Collections.Generic;
using MX.Campaign;

namespace MX.NetworkProtocol
{
    public class ScenarioDeployEchelonRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_DeployEchelon; }
        }

        public long StageUniqueId { get; set; }

        public List<HexaUnit> DeployedEchelons { get; set; }

        public ScenarioDeployEchelonRequest() { }
    }
}
