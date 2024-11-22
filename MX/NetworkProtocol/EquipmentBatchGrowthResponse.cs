using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EquipmentBatchGrowthResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Equipment_BatchGrowth; }
        }

        public List<EquipmentDB> EquipmentDBs { get; set; }

        public GearDB GearDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public ConsumeResultDB ConsumeResultDB { get; set; }

        public EquipmentBatchGrowthResponse() { }
    }
}
