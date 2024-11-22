using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class BillingTransactionEndByYostarResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Billing_TransactionEndByYostar; }
        }

        public ParcelResultDB ParcelResult { get; set; }

        public MailDB MailDB { get; set; }

        public List<PurchaseCountDB> CountList { get; set; }

        public int PurchaseCount { get; set; }

        public List<MonthlyProductPurchaseDB> MonthlyProductList { get; set; }

        public BillingTransactionEndByYostarResponse() { }
    }
}
