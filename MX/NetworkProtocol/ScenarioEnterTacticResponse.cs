namespace MX.NetworkProtocol
{
    public class ScenarioEnterTacticResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_EnterTactic; }
        }

        public ScenarioEnterTacticResponse() { }
    }
}
