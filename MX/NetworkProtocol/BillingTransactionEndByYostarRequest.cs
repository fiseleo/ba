using FlatData;

namespace MX.NetworkProtocol
{
    public class BillingTransactionEndByYostarRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Billing_TransactionEndByYostar; }
        }

        public long PurchaseOrderId { get; set; }

        public BillingTransactionEndType EndType { get; set; }

        public BillingTransactionEndByYostarRequest() { }
    }
}
