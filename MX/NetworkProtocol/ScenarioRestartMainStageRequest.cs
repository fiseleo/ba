namespace MX.NetworkProtocol
{
    public class ScenarioRestartMainStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_RestartMainStage; }
        }

        public long StageUniqueId { get; set; }

        public ScenarioRestartMainStageRequest() { }
    }
}
