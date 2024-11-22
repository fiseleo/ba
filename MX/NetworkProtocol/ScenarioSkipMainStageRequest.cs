namespace MX.NetworkProtocol
{
    public class ScenarioSkipMainStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_SkipMainStage; }
        }

        public long StageUniqueId { get; set; }

        public ScenarioSkipMainStageRequest() { }
    }
}
