namespace MX.NetworkProtocol
{
    public class CharacterListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Character_List; }
        }

        public CharacterListRequest() { }
    }
}
