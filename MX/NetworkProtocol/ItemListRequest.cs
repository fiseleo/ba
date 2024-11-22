namespace MX.NetworkProtocol
{
    public class ItemListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Item_List; }
        }

        public ItemListRequest() { }
    }
}
