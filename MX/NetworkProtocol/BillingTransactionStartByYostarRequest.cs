namespace MX.NetworkProtocol
{
    public class BillingTransactionStartByYostarRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Billing_TransactionStartByYostar; }
        }

        public long ShopCashId { get; set; }

        public bool VirtualPayment { get; set; }

        public BillingTransactionStartByYostarRequest() { }
    }
}
