namespace MX.NetworkProtocol
{
    [Obsolete]
    public class EquipmentItemLockRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Equipment_Lock; }
        }

        public long TargetServerId { get; set; }

        public bool IsLocked { get; set; }

        public EquipmentItemLockRequest() { }
    }
}
