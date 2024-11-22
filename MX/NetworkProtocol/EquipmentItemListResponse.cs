using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EquipmentItemListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Equipment_List; }
        }

        public List<EquipmentDB> EquipmentDBs { get; set; }

        public EquipmentItemListResponse() { }
    }
}
