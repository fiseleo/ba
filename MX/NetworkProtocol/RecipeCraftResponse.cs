using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class RecipeCraftResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Recipe_Craft; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public ConsumeResultDB EquipmentConsumeResultDB { get; set; }

        public ConsumeResultDB ItemConsumeResultDB { get; set; }

        public RecipeCraftResponse() { }
    }
}
