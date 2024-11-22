namespace MX.NetworkProtocol
{
    public class ScenarioAccountStudentChangeRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_AccountStudentChange; }
        }

        public long AccountStudent { get; set; }

        public long AccountStudentBefore { get; set; }

        public ScenarioAccountStudentChangeRequest() { }
    }
}
