using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ScenarioGroupHistoryUpdateResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_GroupHistoryUpdate; }
        }

        public ScenarioGroupHistoryDB ScenarioGroupHistoryDB { get; set; }

        public ScenarioGroupHistoryUpdateResponse() { }
    }
}
