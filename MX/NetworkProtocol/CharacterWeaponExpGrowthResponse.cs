using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class CharacterWeaponExpGrowthResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Character_WeaponExpGrowth; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public CharacterWeaponExpGrowthResponse() { }
    }
}
