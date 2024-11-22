namespace MX.NetworkProtocol
{
    public class CafeSummonCharacterRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_SummonCharacter; }
        }

        public long CafeDBId { get; set; }

        public long CharacterServerId { get; set; }

        public CafeSummonCharacterRequest() { }
    }
}
