namespace MX.GameLogic.DBModel
{
    public class CardShopElementDB
    {
        public long EventContentId { get; set; }

        public int SlotNumber { get; set; }

        public long CardShopElementId { get; set; }

        public bool SoldOut
        {
            get { return default(bool); }
        }

        public CardShopElementDB() { }
    }
}
