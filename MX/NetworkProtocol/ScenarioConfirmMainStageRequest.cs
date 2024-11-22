namespace MX.NetworkProtocol
{
    public class ScenarioConfirmMainStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_ConfirmMainStage; }
        }

        public long StageUniqueId { get; set; }

        public ScenarioConfirmMainStageRequest() { }
    }
}
