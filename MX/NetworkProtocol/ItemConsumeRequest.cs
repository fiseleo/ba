namespace MX.NetworkProtocol
{
    public class ItemConsumeRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Item_Consume; }
        }

        public long TargetItemServerId { get; set; }

        public int ConsumeCount { get; set; }

        public ItemConsumeRequest() { }
    }
}
