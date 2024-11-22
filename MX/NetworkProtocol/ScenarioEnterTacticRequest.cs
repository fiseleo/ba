namespace MX.NetworkProtocol
{
    public class ScenarioEnterTacticRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_EnterTactic; }
        }

        public long StageUniqueId { get; set; }

        public long EchelonIndex { get; set; }

        public long EnemyIndex { get; set; }

        public ScenarioEnterTacticRequest() { }
    }
}
