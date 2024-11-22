using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EquipmentItemLevelUpRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Equipment_LevelUp; }
        }

        public long TargetServerId { get; set; }

        public List<long> ConsumeServerIds { get; set; }

        public ConsumeRequestDB ConsumeRequestDB { get; set; }

        public EquipmentItemLevelUpRequest() { }
    }
}
