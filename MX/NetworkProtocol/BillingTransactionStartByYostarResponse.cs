using FlatData;

namespace MX.NetworkProtocol
{
    public class BillingTransactionStartByYostarResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Billing_TransactionStartByYostar; }
        }

        public long PurchaseCount { get; set; }

        public DateTime PurchaseResetDate { get; set; }

        public long PurchaseOrderId { get; set; }

        public string MXSeedKey { get; set; }

        public PurchaseServerTag PurchaseServerTag { get; set; }

        public BillingTransactionStartByYostarResponse() { }
    }
}
