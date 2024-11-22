using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class CharacterGearTierUpResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.CharacterGear_TierUp; }
        }

        public GearDB GearDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public ConsumeResultDB ConsumeResultDB { get; set; }

        public CharacterGearTierUpResponse() { }
    }
}
