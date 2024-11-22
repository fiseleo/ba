namespace MX.NetworkProtocol
{
    public class ScenarioEnterMainStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_EnterMainStage; }
        }

        public long StageUniqueId { get; set; }

        public ScenarioEnterMainStageRequest() { }
    }
}
