namespace MX.NetworkProtocol
{
    public class CafeInteractWithCharacterRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_Interact; }
        }

        public long CafeDBId { get; set; }

        public long CharacterId { get; set; }

        public CafeInteractWithCharacterRequest() { }
    }
}
