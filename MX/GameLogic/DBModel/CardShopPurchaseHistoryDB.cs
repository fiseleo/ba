using FlatData;

namespace MX.GameLogic.DBModel
{
    public class CardShopPurchaseHistoryDB
    {
        public long EventContentId { get; set; }

        public Rarity Rarity { get; set; }

        public long PurchaseCount { get; set; }

        public CardShopPurchaseHistoryDB() { }
    }
}
