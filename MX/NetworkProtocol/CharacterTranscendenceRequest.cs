namespace MX.NetworkProtocol
{
    public class CharacterTranscendenceRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Character_Transcendence; }
        }

        public long TargetCharacterServerId { get; set; }

        public CharacterTranscendenceRequest() { }
    }
}
