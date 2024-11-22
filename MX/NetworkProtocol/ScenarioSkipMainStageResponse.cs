namespace MX.NetworkProtocol
{
    public class ScenarioSkipMainStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_SkipMainStage; }
        }

        public ScenarioSkipMainStageResponse() { }
    }
}
