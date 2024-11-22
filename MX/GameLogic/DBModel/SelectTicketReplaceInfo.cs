using FlatData;

namespace MX.GameLogic.DBModel
{
    public class SelectTicketReplaceInfo
    {
        public ParcelType MaterialType { get; set; }

        public long MaterialId { get; set; }

        public long TicketItemId { get; set; }

        public int Amount { get; set; }

        public SelectTicketReplaceInfo Clone()
        {
            return null;
        }

        public SelectTicketReplaceInfo() { }
    }
}
