using MX.Logic.Battles.Summary;

namespace MX.NetworkProtocol
{
    public class ScenarioClearRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_Clear; }
        }

        public long ScenarioId { get; set; }

        public BattleSummary BattleSummary { get; set; }

        public ScenarioClearRequest() { }
    }
}
