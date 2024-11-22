namespace MX.NetworkProtocol
{
    public class ItemBulkConsumeRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Item_BulkConsume; }
        }

        public long TargetItemServerId { get; set; }

        public int ConsumeCount { get; set; }

        public ItemBulkConsumeRequest() { }
    }
}
