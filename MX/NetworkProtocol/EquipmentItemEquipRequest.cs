using System.Collections.Generic;

namespace MX.NetworkProtocol
{
    public class EquipmentItemEquipRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Equipment_Equip; }
        }

        public long CharacterServerId { get; set; }

        public List<long> EquipmentServerIds { get; set; }

        public long EquipmentServerId { get; set; }

        public int SlotIndex { get; set; }

        public EquipmentItemEquipRequest() { }
    }
}
