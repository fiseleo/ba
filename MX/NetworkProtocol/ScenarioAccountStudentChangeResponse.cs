namespace MX.NetworkProtocol
{
    public class ScenarioAccountStudentChangeResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_AccountStudentChange; }
        }

        public ScenarioAccountStudentChangeResponse() { }
    }
}
