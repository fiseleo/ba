using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    [Obsolete]
    public class EquipmentItemLockResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Equipment_Lock; }
        }

        public EquipmentDB EquipmentDB { get; set; }

        public EquipmentItemLockResponse() { }
    }
}
