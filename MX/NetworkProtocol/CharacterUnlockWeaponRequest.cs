namespace MX.NetworkProtocol
{
    public class CharacterUnlockWeaponRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Character_UnlockWeapon; }
        }

        public long TargetCharacterServerId { get; set; }

        public CharacterUnlockWeaponRequest() { }
    }
}
