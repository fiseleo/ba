using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class ItemConsumeResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Item_Consume; }
        }

        public ItemDB UsedItemDB { get; set; }

        public ParcelResultDB NewParcelResultDB { get; set; }

        public ItemConsumeResponse() { }
    }
}
