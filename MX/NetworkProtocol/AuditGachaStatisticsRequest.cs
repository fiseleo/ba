namespace MX.NetworkProtocol
{
    public class AuditGachaStatisticsRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Audit_GachaStatistics; }
        }

        public long MerchandiseUniqueId { get; set; }

        public long ShopUniqueId { get; set; }

        public long Count { get; set; }

        public AuditGachaStatisticsRequest() { }
    }
}
