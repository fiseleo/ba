namespace MX.NetworkProtocol
{
    public class CraftInfoListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Craft_List; }
        }

        public CraftInfoListRequest() { }
    }
}
