namespace MX.NetworkProtocol
{
    public class AccountReportXignCodeCheaterRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_ReportXignCodeCheater; }
        }

        public string ErrorCode { get; set; }

        public AccountReportXignCodeCheaterRequest() { }
    }
}
