using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EquipmentItemTierUpResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Equipment_TierUp; }
        }

        public EquipmentDB EquipmentDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public ConsumeResultDB ConsumeResultDB { get; set; }

        public EquipmentItemTierUpResponse() { }
    }
}
