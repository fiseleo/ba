using System.Collections.Generic;

namespace MX.NetworkProtocol
{
    public class ScenarioWithdrawEchelonRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_WithdrawEchelon; }
        }

        public long StageUniqueId { get; set; }

        public List<long> WithdrawEchelonEntityId { get; set; }

        public ScenarioWithdrawEchelonRequest() { }
    }
}
