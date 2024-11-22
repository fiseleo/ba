using System.Collections.Generic;

namespace MX.NetworkProtocol
{
    public class AuditGachaStatisticsResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Audit_GachaStatistics; }
        }

        public Dictionary<long, long> GachaResult { get; set; }

        public AuditGachaStatisticsResponse() { }
    }
}
