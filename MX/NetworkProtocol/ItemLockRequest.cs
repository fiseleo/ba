namespace MX.NetworkProtocol
{
    [Obsolete]
    public class ItemLockRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Item_Lock; }
        }

        public long TargetServerId { get; set; }

        public bool IsLocked { get; set; }

        public ItemLockRequest() { }
    }
}
