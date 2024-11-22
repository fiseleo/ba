using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CharacterUnlockWeaponResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Character_UnlockWeapon; }
        }

        public WeaponDB WeaponDB { get; set; }

        public CharacterUnlockWeaponResponse() { }
    }
}
