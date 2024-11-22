namespace MX.NetworkProtocol
{
    public class CharacterWeaponTranscendenceRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Character_WeaponTranscendence; }
        }

        public long TargetCharacterServerId { get; set; }

        public CharacterWeaponTranscendenceRequest() { }
    }
}
