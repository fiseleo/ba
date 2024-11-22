using FlatData;

namespace MX.GameLogic.DBModel
{
    public class PurchaseOrderDB
    {
        public long ShopCashId { get; set; }

        public PurchaseStatusCode StatusCode { get; set; }

        public long PurchaseOrderId { get; set; }

        public PurchaseOrderDB() { }
    }
}
