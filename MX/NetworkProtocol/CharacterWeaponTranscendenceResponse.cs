using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class CharacterWeaponTranscendenceResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Character_WeaponTranscendence; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public CharacterWeaponTranscendenceResponse() { }
    }
}
