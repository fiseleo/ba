using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EquipmentItemEquipResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Equipment_Equip; }
        }

        public EquipmentItemEquipResponse() { }

        public CharacterDB CharacterDB;

        public List<EquipmentDB> EquipmentDBs;
    }
}
