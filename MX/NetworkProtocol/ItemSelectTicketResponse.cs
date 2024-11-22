using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class ItemSelectTicketResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Item_SelectTicket; }
        }

        public ItemDB UsedItemDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public ItemSelectTicketResponse() { }
    }
}
