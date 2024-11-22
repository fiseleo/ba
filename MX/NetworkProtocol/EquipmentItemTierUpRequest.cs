using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EquipmentItemTierUpRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Equipment_TierUp; }
        }

        public long TargetEquipmentServerId { get; set; }

        public List<SelectTicketReplaceInfo> ReplaceInfos { get; set; }

        public EquipmentItemTierUpRequest() { }
    }
}
