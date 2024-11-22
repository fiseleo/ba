namespace MX.NetworkProtocol
{
    public class BillingPurchaseListByYostarRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Billing_PurchaseListByYostar; }
        }

        public BillingPurchaseListByYostarRequest() { }
    }
}
