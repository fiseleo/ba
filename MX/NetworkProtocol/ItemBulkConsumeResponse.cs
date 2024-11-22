using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class ItemBulkConsumeResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Item_BulkConsume; }
        }

        public ItemDB UsedItemDB { get; set; }

        public List<ParcelInfo> ParcelInfosInMailBox { get; set; }

        public ItemBulkConsumeResponse() { }
    }
}
