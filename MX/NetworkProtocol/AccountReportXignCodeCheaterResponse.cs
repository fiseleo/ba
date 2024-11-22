namespace MX.NetworkProtocol
{
    public class AccountReportXignCodeCheaterResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_ReportXignCodeCheater; }
        }

        public AccountReportXignCodeCheaterResponse() { }
    }
}
