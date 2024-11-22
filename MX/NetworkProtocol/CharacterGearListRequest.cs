namespace MX.NetworkProtocol
{
    public class CharacterGearListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.CharacterGear_List; }
        }

        public CharacterGearListRequest() { }
    }
}
