using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class BillingPurchaseListByYostarResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Billing_PurchaseListByYostar; }
        }

        public List<PurchaseCountDB> CountList { get; set; }

        public List<PurchaseOrderDB> OrderList { get; set; }

        public List<MonthlyProductPurchaseDB> MonthlyProductList { get; set; }

        public List<BlockedProductDB> BlockedProductDBs { get; set; }

        public BillingPurchaseListByYostarResponse() { }
    }
}
